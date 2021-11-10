using System;
using System.Runtime.Serialization;

namespace Service.Exchange.Sdk.Models
{
    [DataContract]
    public class ExBalance
    {
        [DataMember(Order = 1)] public string WalletId { get; set; }
        [DataMember(Order = 2)] public string AssetId { get; set; }
        [DataMember(Order = 3)] public decimal Balance { get; set; }
        [DataMember(Order = 4)] public decimal ReserveBalance { get; set; }
        [DataMember(Order = 5)] public DateTime LastUpdate { get; set; }
    }
}