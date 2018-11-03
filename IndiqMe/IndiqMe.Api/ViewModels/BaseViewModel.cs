using Newtonsoft.Json;
using IndiqMe.Domain.Common;
using System;

namespace IndiqMe.Api.ViewModels
{
    public abstract class BaseViewModel : IIdProperty
    {
        [JsonIgnore]
        public Guid Id { get; set; }
    }
}
