using System;
using System.Runtime.Serialization;

namespace Service.Exchange.Sdk.Models
{
    [DataContract]
    public class ExOrder
    {
        [DataMember(Order = 1)] public string Id { get; set; }
        [DataMember(Order = 2)] public string WalletId { get; set; }
        [DataMember(Order = 3)] public string AssetPairId { get; set; }
        [DataMember(Order = 4)] public decimal Price { get; set; }
        [DataMember(Order = 5)] public decimal Volume { get; set; }
        [DataMember(Order = 6)] public string VolumeOpposite { get; set; }
        [DataMember(Order = 7)] public string ExecutedVolume { get; set; }
        [DataMember(Order = 8)] public ExOrderSide OrderSide { get; set; }
        [DataMember(Order = 9)] public ExOrderType Type { get; set; }
        
        [DataMember(Order = 10)] public uint Version { get; set; }
        [DataMember(Order = 11)] public DateTime CreatedTime { get; set; }
        [DataMember(Order = 12)] public DateTime UpdatedTime { get; set; }
    }
}