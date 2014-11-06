﻿using System;
using BankTransferSample.Domain;
using ENode.Commanding;

namespace BankTransferSample.Commands
{
    /// <summary>发起一笔转账交易
    /// </summary>
    [Serializable]
    public class StartTransferTransactionCommand : AggregateCommand<string>, ICreatingAggregateCommand
    {
        /// <summary>转账交易信息
        /// </summary>
        public TransferTransactionInfo TransactionInfo { get; private set; }

        public StartTransferTransactionCommand(TransferTransactionInfo transactionInfo)
        {
            TransactionInfo = transactionInfo;
        }
    }
    /// <summary>确认账号验证已通过
    /// </summary>
    [Serializable]
    public class ConfirmAccountValidatePassedCommand : AggregateCommand<string>
    {
        /// <summary>账号ID
        /// </summary>
        public string AccountId { get; private set; }

        public ConfirmAccountValidatePassedCommand(string transactionId, string accountId)
            : base(transactionId)
        {
            AccountId = accountId;
        }
    }
    /// <summary>确认预转出
    /// </summary>
    [Serializable]
    public class ConfirmTransferOutPreparationCommand : AggregateCommand<string>
    {
        public ConfirmTransferOutPreparationCommand(string transactionId)
            : base(transactionId)
        {
        }
    }
    /// <summary>确认预转入
    /// </summary>
    [Serializable]
    public class ConfirmTransferInPreparationCommand : AggregateCommand<string>
    {
        public ConfirmTransferInPreparationCommand(string transactionId)
            : base(transactionId)
        {
        }
    }
    /// <summary>确认转出
    /// </summary>
    [Serializable]
    public class ConfirmTransferOutCommand : AggregateCommand<string>
    {
        public ConfirmTransferOutCommand(string transactionId)
            : base(transactionId)
        {
        }
    }
    /// <summary>确认转入
    /// </summary>
    [Serializable]
    public class ConfirmTransferInCommand : AggregateCommand<string>
    {
        public ConfirmTransferInCommand(string transactionId)
            : base(transactionId)
        {
        }
    }
    /// <summary>取消转账交易
    /// </summary>
    [Serializable]
    public class CancelTransferTransactionCommand : AggregateCommand<string>
    {
        public CancelTransferTransactionCommand(string transactionId)
            : base(transactionId)
        {
        }
    }
}
