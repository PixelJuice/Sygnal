using System;
using UnityEngine;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "SharedFloat", menuName = "JJ/Communication/SharedDataObjects/SharedFloat", order = 1)]
    public class SharedFloatSO : ScriptableObject, ISharedDataObject<Action<float>>
    {
        [SerializeField]
        private SharedFloat m_sharedFloat = new SharedFloat();
        public float Value
        {
            get { return m_sharedFloat.Value; }
            set
            {
                m_sharedFloat.Value = value;
            }
        }
        
        public void DeRegister(Action<float> p_listener)
        {
            m_sharedFloat.DeRegister(p_listener);
        }

        public void Register(Action<float> p_listener)
        {
            m_sharedFloat.Register(p_listener);
        }
    }
}
