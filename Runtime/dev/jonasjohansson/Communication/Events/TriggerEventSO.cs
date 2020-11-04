using System;
using UnityEngine;

namespace dev.jonasjohansson.Communication.Events
{
    [CreateAssetMenu(fileName = "TriggerEvent", menuName = "JJ/Communication/Events/TriggerEvent", order = 1)]
    public class TriggerEventSO :ScriptableObject, IEvent<Action>, ITriggerEvent
    {
        private TriggerEvent m_event = new TriggerEvent();
        public void DeRegister(Action p_listener)
        {
            m_event.DeRegister(p_listener);
        }

        public void Raise()
        {
            m_event.Raise();
        }

        public void Register(Action p_listener)
        {
            m_event.Register(p_listener);
        }
    }
}