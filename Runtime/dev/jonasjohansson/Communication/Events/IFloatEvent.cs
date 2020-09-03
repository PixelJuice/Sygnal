using System;

namespace dev.jonasjohansson.Communication.Events
{
    public interface IFloatEvent : IEvent<Action<float>>
    {
        void Raise(float p_value);
    }
}
