using System;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    [Serializable]
    public class SharedString : SharedDataObject<Action<String>>, ISharedString
    {
        private String m_value = string.Empty;
        public String Value
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
