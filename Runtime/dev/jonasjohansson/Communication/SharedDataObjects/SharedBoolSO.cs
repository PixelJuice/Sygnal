using System;
using UnityEngine;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "SharedBool", menuName = "JJ/Communication/SharedDataObjects/SharedBool", order = 1)]
    public class SharedBoolSO : ScriptableObject, ISharedDataObject<Action<bool>>
    {
        [SerializeField]
        private SharedBool m_SharedBool = new SharedBool();
        public bool Value
        {
            get { return m_SharedBool.Value; }
            set
            {
                m_SharedBool.Value = value;
            }
        }
        
        public void DeRegister(Action<bool> p_listener)
        {
            m_SharedBool.DeRegister(p_listener);
        }

        public void Register(Action<bool> p_listener)
        {
            m_SharedBool.Register(p_listener);
        }
    }
}
