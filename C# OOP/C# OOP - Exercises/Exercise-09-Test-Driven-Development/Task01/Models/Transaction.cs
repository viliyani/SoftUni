using System;
using Chainblock.Contracts;
using Chainblock.Common;

namespace Chainblock.Models
{
    public class Transaction : ITransaction
    {
        private const int MIN_ID_VAL = 0;
        private const double MIN_AMOUN_VAL = 0.0;

        private int id;
        private string from;
        private string to;
        private double amount;

        public Transaction(int id, TransactionStatus transactionStatus, string from, string to, double amount)
        {
            Id = id;
            Status = transactionStatus;
            From = from;
            To = to;
            Amount = amount;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= MIN_ID_VAL)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidIdMessage);
                }

                id = value;
            }
        }

        public TransactionStatus Status { get; set; }

        public string From
        {
            get
            {
                return from;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidSenderUsernameMessage);
                }

                from = value;
            }
        }

        public string To
        {
            get
            {
                return to;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidReceiverUsernameMessage);
                }

                to = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }

            set
            {
                if (value <= MIN_AMOUN_VAL)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTransactionAmountMessage);
                }

                amount = value;
            }
        }

    }
}
