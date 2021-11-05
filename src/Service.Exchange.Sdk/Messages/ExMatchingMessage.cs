using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Service.Exchange.Sdk.Models;

namespace Service.Exchange.Sdk.Messages
{
    [DataContract]
    public class ExMatchingMessage
    {
        [DataMember(Order = 1)] public string OperationId { get; set; }
        [DataMember(Order = 2)] public DateTime Timestamp { get; set; }
        [DataMember(Order = 3)] public MessageCommand Command { get; set; }
        
        [DataMember(Order = 4)] public List<OrderUpdate> Updates { get; set; }
        [DataMember(Order = 5)] public MatchingInstruction Match { get; set; }


        [DataContract]
        public class MatchingInstruction
        {
            [DataMember(Order = 1)] public List<MatchedOrder> Takers { get; set; }
            [DataMember(Order = 2)] public List<MatchedOrder> Makers { get; set; }
            [DataMember(Order = 3)] public FeeInstruction Fee { get; set; }
            [DataMember(Order = 4)] public List<UnReserveInstruction> UnReserve { get; set; }
        }

        public enum MessageCommand
        {
            Unknown = 0,
            OrderChange = 1,
            InitMe = 2
        }

        public enum OrderAction
        {
            Unknown = 0,
            Placed = 1,
            Updated = 2,
            Canceled = 3,
            Executed = 4
        }

        [DataContract]
        public class OrderUpdate
        {
            [DataMember(Order = 1)] public OrderAction Action { get; set; }
            [DataMember(Order = 2)] public ExOrder Order { get; set; }
        }

        [DataContract]
        public class MatchedOrder
        {
            [DataMember(Order = 1)] public uint Number { get; set; }
            [DataMember(Order = 2)] public ExOrder Order { get; set; }
            [DataMember(Order = 3)] public decimal Amount { get; set; }
        }

        [DataContract]
        public class FeeInstruction
        {
            [DataMember(Order = 1)] public string Asset { get; set; }
            [DataMember(Order = 2)] public decimal Amount { get; set; }
            [DataMember(Order = 3)] public string WalletId { get; set; }
        }

        [DataContract]
        public class UnReserveInstruction
        {
            [DataMember(Order = 1)] public uint Number { get; set; }
            [DataMember(Order = 2)] public string WalletId { get; set; }
            [DataMember(Order = 3)] public string Asset { get; set; }
            [DataMember(Order = 4)] public decimal Amount { get; set; }
        }
    }
}