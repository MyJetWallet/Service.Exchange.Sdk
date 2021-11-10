using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Service.Exchange.Sdk.Models;

namespace Service.Exchange.Sdk.Grpc
{
    [DataContract]
    public class CreateOrderRequest
    {
        [DataMember(Order = 1)] public string RequestId { get; set; }
        [DataMember(Order = 2)] public string WalletId { get; set; }
        [DataMember(Order = 3)] public string AssetPairId { get; set; }
        [DataMember(Order = 4)] public CreateOrderMode Mode { get; set; }
        [DataMember(Order = 5)] public DateTime Timestamp { get; set; }
        [DataMember(Order = 6)] public List<ExOrder> Orders { get; set; }
    }

    [DataContract]
    public enum CreateOrderMode
    {
        Unknown = 0,
        Create = 1,
        ClearAndCreate = 2
    }
}