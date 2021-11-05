using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Exchange.Sdk.Messages
{
    [DataContract]
    public class ExBalanceUpdate
    {
        [DataMember(Order = 1)] public string OperationId { get; set; }
        [DataMember(Order = 2)] public string Instance { get; set; }
        [DataMember(Order = 3)] public DateTime Timestamp { get; set; }
        [DataMember(Order = 4)] public List<Update> Updates { get; set; }
        
        [DataContract]
        public class Update
        {
            [DataMember(Order = 1)] public uint Number { get; set; }
            [DataMember(Order = 2)] public string WalletId { get; set; }
            [DataMember(Order = 3)] public string AssetId { get; set; }
            [DataMember(Order = 4)] public decimal Amount { get; set; }
            [DataMember(Order = 5)] public decimal OldBalance { get; set; }
            [DataMember(Order = 6)] public decimal NewBalance { get; set; }
        }
    }
}