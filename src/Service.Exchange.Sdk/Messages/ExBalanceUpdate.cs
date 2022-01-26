using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Service.Exchange.Sdk.Models;

namespace Service.Exchange.Sdk.Messages
{
    [DataContract]
    public class ExBalanceUpdate
    {
        [DataMember(Order = 1)] public string OperationId { get; set; }
        [DataMember(Order = 2)] public string Instance { get; set; }
        [DataMember(Order = 3)] public DateTime Timestamp { get; set; }
        [DataMember(Order = 4)] public string EventType { get; set; }
        [DataMember(Order = 5)] public BalanceUpdateResult Result { get; set; }
        [DataMember(Order = 6)] public List<Update> Updates { get; set; }
        [DataMember(Order = 7)] public List<ExBalance> Balances { get; set; }
        
        [DataContract]
        public class Update
        {
            [DataMember(Order = 1)] public uint Number { get; set; }
            [DataMember(Order = 2)] public string WalletId { get; set; }
            [DataMember(Order = 3)] public string AssetId { get; set; }
            [DataMember(Order = 4)] public decimal Amount { get; set; }
            [DataMember(Order = 5)] public decimal ReserveAmount { get; set; }
            
            [DataMember(Order = 6)] public decimal OldBalance { get; set; }
            [DataMember(Order = 7)] public decimal NewBalance { get; set; }
            [DataMember(Order = 8)] public decimal ReserveOldBalance { get; set; }
            [DataMember(Order = 9)] public decimal ReserveNewBalance { get; set; }
            
            [DataMember(Order = 10)] public BalanceUpdateResult Result { get; set; }
            [DataMember(Order = 11)] public string ErrorMessage { get; set; }
            
            [DataMember(Order = 12)] public decimal ReserveFuturesPositions  { get; set; }
            [DataMember(Order = 13)] public decimal ReserveNewFuturesPositions  { get; set; }
            [DataMember(Order = 14)] public decimal ReserveOldFuturesPositions { get; set; }
            [DataMember(Order = 15)] public decimal ReserveFuturesOrders  { get; set; }
            [DataMember(Order = 16)] public decimal ReserveNewFuturesOrders  { get; set; }
            [DataMember(Order = 17)] public decimal ReserveOldFuturesOrders { get; set; }
        }

        [DataContract]
        public enum BalanceUpdateResult
        {
            Unknown = 0,
            Ok = 1,
            Failed = 2,
            LowBalance = 3,
            LowReserveBalance = 4
        }
    }
}