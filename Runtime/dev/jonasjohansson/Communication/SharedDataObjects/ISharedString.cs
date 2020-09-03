using System;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    public interface ISharedString : ISharedDataObject<Action<String>>
    {
        string Value { get; set; }
    }
}