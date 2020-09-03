using System.Collections.Generic;

namespace dev.jonasjohansson.Communication.SharedDataObjects {
    public abstract class SharedDataObject<T> : ISharedDataObject<T>
    {
        protected List<T> m_eventListeners = new List<T>();

        public void Register(T p_listener)
        {
            if (!m_eventListeners.Contains(p_listener))
            {
                m_eventListeners.Add(p_listener);
            }
        }

        public void DeRegister(T p_listener)
        {
            if (m_eventListeners.Contains(p_listener))
            {
                m_eventListeners.Remove(p_listener);
            }
        }

        protected internal abstract void Changed();
    }
}
