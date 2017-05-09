/*
 * Copyright 2015 Tomi Valkeinen
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace NetSerializer
{
	/// <summary>
	/// Threadsafe Type -> T dictionary, which supports lockless reading.
	/// </summary>
	class TypeDictionary
	{
		struct Pair
		{
			public Pair(Type key, TypeData value)
			{
				this.Key = key;
				this.Value = value;
			}

			public Type Key;
			public TypeData Value;
		}

		Pair[][] m_buckets;
		object m_writeLock = new object();
		int m_numItems;

		const int InitialListSize = 1;
		const float LoadLimit = 0.50f;
		const int InitialLength = 256;

		public TypeDictionary()
		{
			int numBuckets = (int)(InitialLength * (1.0f / LoadLimit));
			m_buckets = new Pair[numBuckets][];
		}

		public bool ContainsKey(Type key)
		{
			TypeData value;
			return TryGetValue(key, out value);
		}

		public bool TryGetValue(Type key, out TypeData value)
		{
#if !NET35 && !NET40
			var buckets = Volatile.Read(ref m_buckets);
#else
			var buckets = Read(ref m_buckets);
#endif
			int idx = Hash(key, buckets.Length);

#if !NET35 && !NET40
			Pair[] arr = Volatile.Read(ref buckets[idx]);
#else
			Pair[] arr = Read(ref buckets[idx]);
#endif
			if(arr == null)
			goto not_found;

			for (int i = 0; i < arr.Length; ++i)
			{
				if (arr[i].Key == key)
				{
					value = arr[i].Value;
					return true;
				}
			}

			not_found:
			value = null;
			return false;
		}

		public TypeData this[Type key]
		{
			get
			{
#if !NET35 && !NET40
			var buckets = Volatile.Read(ref m_buckets);
#else
				var buckets = Read(ref m_buckets);
#endif
				int idx = Hash(key, buckets.Length);

#if !NET35 && !NET40
			Pair[] arr = Volatile.Read(ref buckets[idx]);
#else
				Pair[] arr = Read(ref buckets[idx]);
#endif
				if (arr == null)
					throw new KeyNotFoundException(String.Format("Type not found {0}", key));

				for (int i = 0; i < arr.Length; ++i)
				{
					if (arr[i].Key == key)
						return arr[i].Value;
				}

				throw new KeyNotFoundException(String.Format("Type not found {0}", key));
			}

			set
			{
				lock (m_writeLock)
				{
					Debug.Assert(ContainsKey(key) == false);

					if (m_numItems >= m_buckets.Length * LoadLimit)
					{
						var newBuckets = new Pair[m_buckets.Length * 2][];

						foreach (var list in m_buckets.Where(l => l != null))
						{
							foreach (var pair in list.Where(p => p.Key != null))
								Add(newBuckets, pair.Key, pair.Value);
						}

#if !NET35 && !NET40
						Volatile.Write(ref m_buckets, newBuckets);
#else
						Write(ref m_buckets, newBuckets);
#endif
					}

					Add(m_buckets, key, value);

					m_numItems++;
				}
			}
		}

		static void Add(Pair[][] buckets, Type key, TypeData value)
		{
			int idx = Hash(key, buckets.Length);

			Pair[] arr = buckets[idx];
			if (arr == null)
				buckets[idx] = arr = new Pair[InitialListSize];

			for (int i = 0; i < arr.Length; ++i)
			{
				if (arr[i].Key == null)
				{
					arr[i] = new Pair(key, value);
					return;
				}
			}

			var newArr = new Pair[arr.Length * 2];
			Array.Copy(arr, newArr, arr.Length);
			newArr[arr.Length] = new Pair(key, value);
			buckets[idx] = newArr;
		}

		static int Hash(Type key, int bucketsLen)
		{
			uint h = (uint)System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(key);
			h %= (uint)bucketsLen;
			return (int)h;
		}

		public Dictionary<Type, uint> ToDictionary()
		{
			var map = new Dictionary<Type, uint>(m_numItems);

			foreach (var list in m_buckets)
			{
				if (list == null)
					continue;

				foreach (var pair in list)
				{
					if (pair.Key == null)
						continue;

					var td = pair.Value;

					map[td.Type] = td.TypeID;
				}
			}

			return map;
		}


		[Conditional("DEBUG")]
		public void DebugDump()
		{
			int occupied = m_buckets.Count(i => i != null);

			Console.WriteLine("bucket arr len {0}, items {1}, occupied buckets {2}", m_buckets.Length, m_numItems, occupied);

			var countmap = new Dictionary<int, int>();
			foreach (var list in m_buckets)
			{
				if (list == null)
					continue;

				int c = list.TakeWhile(p => p.Key != null).Count();
				if (countmap.ContainsKey(c) == false)
					countmap[c] = 0;
				countmap[c]++;
			}

			foreach (var kvp in countmap.OrderBy(kvp => kvp.Key))
				Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
		}
#if NET35 || NET40
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success), System.Security.SecuritySafeCritical, __DynamicallyInvokable]
		private static T Read<T>(ref T location) where T : class
		{
			T result = location;
			Thread.MemoryBarrier();
			return result;
		}
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success), System.Security.SecuritySafeCritical, __DynamicallyInvokable]
		private static void Write<T>(ref T location, T value) where T : class
		{
			Thread.MemoryBarrier();
			location = value;
		}

#endif

	}
#if NET35 || NET40
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	internal sealed class __DynamicallyInvokableAttribute : Attribute
	{
		// Token: 0x06006F5B RID: 28507 RVA: 0x0017B824 File Offset: 0x00179A24
		public __DynamicallyInvokableAttribute()
		{
		}
	}
#endif
}
