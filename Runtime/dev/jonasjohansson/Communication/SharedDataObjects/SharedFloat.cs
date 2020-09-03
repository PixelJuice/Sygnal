using System;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [Serializable]
    public class SharedFloat : SharedDataObject<Action<float>>, ISharedFloat
    {
        private float m_value = 0;
        public float Value
        {
            get { return m_value; }
            set
            {
                m_value = value;
                Changed();
            }
        }

        protected internal override void Changed()
        {
            for (int i = m_eventListeners.Count - 1; i >= 0; i--)
            {
                m_eventListeners[i].Invoke(m_value);
            }
        }
    }
}
