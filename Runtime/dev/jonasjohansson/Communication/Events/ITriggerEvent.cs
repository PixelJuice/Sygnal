using System;

namespace dev.jonasjohansson.Communication.Events
{
    public interface ITriggerEvent : IEvent<Action>
    {
        void Raise();
    }
}