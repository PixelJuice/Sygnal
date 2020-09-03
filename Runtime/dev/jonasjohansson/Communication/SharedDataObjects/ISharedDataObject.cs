namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    public interface ISharedDataObject<T> 
    {
        void DeRegister(T p_listener);
        void Register(T p_listener);

    }
}