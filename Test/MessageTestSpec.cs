using System;
using System.Reflection;

namespace Test
{
	class MessageTestSpec<T> : ITestSpec
	{
		int m_numMessages;
		int m_loops;
		bool m_direct;

		Func<MyRandom, T> m_creator;
		Action<T, T> m_comparer;

		public ITest Create()
		{
			return new MessageTest<T>(m_numMessages, m_loops, m_direct, m_creator, m_comparer);
		}

		public Type Type { get { return typeof(T); } }

		public MessageTestSpec(int numMessages, int loops, bool direct = false, Func<MyRandom, T> creator = null, Action<T, T> comparer = null)
		{
			m_numMessages = numMessages;
			m_loops = loops;
			m_direct = direct;

			if (creator == null)
			{
#if !NET35 && !NET40
				var method = typeof(T).GetTypeInfo().GetMethod("Create", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
				creator = (Func<MyRandom, T>)method.CreateDelegate(typeof(Func<MyRandom, T>));
#else
				var method = typeof(T).GetMethod("Create", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
				creator = (Func<MyRandom, T>)Delegate.CreateDelegate(typeof(Func<MyRandom, T>), method);
#endif
			}

			m_creator = creator;

			if (comparer == null)
			{
				var method = typeof(T).GetMethod("Compare", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
				if (method != null)
				{
#if !NET35 && !NET40
					comparer = (Action<T, T>)method.CreateDelegate(typeof(Action<T, T>));
#else
					comparer = (Action<T, T>)Delegate.CreateDelegate(typeof(Action<T, T>),method);
#endif
				}
			}

			m_comparer = comparer;
		}
	}
}
