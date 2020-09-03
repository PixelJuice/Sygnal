using System;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    public interface ISharedBool : ISharedDataObject<Action<bool>>
    {
        bool Value { get; set; }
    }
}