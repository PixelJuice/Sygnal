using System;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [Serializable]
    public class SharedBool : SharedDataObject<Action<bool>>, ISharedBool
    {
        private bool m_value = false;
        public bool Value
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
