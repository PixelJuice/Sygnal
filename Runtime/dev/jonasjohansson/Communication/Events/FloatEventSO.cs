using System;
using UnityEngine;

namespace dev.jonasjohansson.Communication.Events
{
    [CreateAssetMenu(fileName = "FloatEvent", menuName = "JJ/Events/FloatEvent", order = 1)]
    public class FloatEventSO :ScriptableObject, IEvent<Action<float>>, IFloatEvent
    {
        private FloatEvent m_event = new FloatEvent();
        public void DeRegister(Action<float> p_listener)
        {
            m_event.DeRegister(p_listener);
        }

        public void Raise(float p_value)
        {
            m_event.Raise(p_value);
        }

        public void Register(Action<float> p_listener)
        {
            m_event.Register(p_listener);
        }
    }
}