namespace dev.jonasjohansson.Communication.Events
{
    public interface IEvent<T>
    {
        void DeRegister(T p_listener);
        void Register(T p_listener);
    }
}
