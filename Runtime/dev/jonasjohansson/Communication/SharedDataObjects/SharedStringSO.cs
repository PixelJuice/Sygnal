using System;
using UnityEngine;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [CreateAssetMenu(fileName = "SharedString", menuName = "JJ/Communication/SharedDataObjects/SharedString", order = 1)]
    public class SharedStringSO : ScriptableObject, ISharedDataObject<Action<String>>
    {
        private SharedString m_value = new SharedString();
        public String Value
        {
            get { return m_value.Value; }
            set
            {
                m_value.Value = value;
            }
        }

        public void DeRegister(Action<string> p_listener)
        {
            m_value.DeRegister(p_listener);
        }

        public void Register(Action<string> p_listener)
        {
            m_value.Register(p_listener);
        }
    }
}
