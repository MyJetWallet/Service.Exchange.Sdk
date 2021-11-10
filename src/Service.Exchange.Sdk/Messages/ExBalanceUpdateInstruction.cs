using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Exchange.Sdk.Messages
{
    [DataContract]
    public class ExBalanceUpdateInstruction
    {
        [DataMember(Order = 1)] public string OperationId { get; set; }
        [DataMember(Order = 2)] public DateTime Timestamp { get; set; }
        [DataMember(Order = 3)] public List<BalanceUpdate> Updates { get; set; }

        [DataContract]
        public class BalanceUpdate
        {
            [DataMember(Order = 1)] public uint Number { get; set; }
            [DataMember(Order = 2)] public string WalletId { get; set; }
            [DataMember(Order = 3)] public string AssetId { get; set; }
            [DataMember(Order = 4)] public decimal Amount { get; set; }
            [DataMember(Order = 5)] public decimal ReserveAmount { get; set; }
        }
    }
}