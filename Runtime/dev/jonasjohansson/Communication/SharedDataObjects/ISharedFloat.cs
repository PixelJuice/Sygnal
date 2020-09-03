using System;

namespace dev.jonasjohansson.Communication.SharedDataObjects
{
    public interface ISharedFloat : ISharedDataObject<Action<float>>
    {
        float Value { get; set; }
    }
}