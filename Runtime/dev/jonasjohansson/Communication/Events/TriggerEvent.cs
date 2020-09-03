using System;

namespace dev.jonasjohansson.Communication.Events
{
    public class TriggerEvent : Event<Action> , ITriggerEvent
    {
        public void Raise()
        {
            for (int i = m_eventListeners.Count - 1; i >= 0; i--)
            {
                m_eventListeners[i].Invoke();
            }
        }
    }
}