using System;
using System.Runtime.Serialization;

namespace Service.Exchange.Sdk.Models
{
    [DataContract]
    public class ExBalance
    {
        public static readonly string KeySeparator = "::";
        
        [DataMember(Order = 1)] public string WalletId { get; set; }
        [DataMember(Order = 2)] public string AssetId { get; set; }
        [DataMember(Order = 3)] public decimal Balance { get; set; }
        [DataMember(Order = 4)] public decimal ReserveBalance { get; set; }
        [DataMember(Order = 5)] public DateTime LastUpdate { get; set; }
        [DataMember(Order = 6)] public long Version { get; set; }
        [DataMember(Order = 7)] public decimal ReserveFuturesPositions  { get; set; }
        [DataMember(Order = 8)] public decimal ReserveFuturesOrders  { get; set; }

        public string WalletIdAssetId
        {
            get => $"{WalletId}{KeySeparator}{AssetId}";
            // ReSharper disable once ValueParameterNotUsed
            set { }
        }
    }
}