using System.Collections.Generic;

namespace dev.jonasjohansson.Communication.Events
{
    public abstract class Event<T> : IEvent<T>
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
    }
}
