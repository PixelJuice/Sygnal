using System;

namespace dev.jonasjohansson.Communication.Events
{
    public class FloatEvent : Event<Action<float>>, IFloatEvent
    {
        public void Raise(float p_value)
        {
            for (int i = m_eventListeners.Count - 1; i >= 0; i--)
            {
                m_eventListeners[i].Invoke(p_value);
            }
        }
    }
}