﻿using System;
using System.Collections.Generic;
using System.Linq;
using InvisibleCollectorLib.Utils;
using Newtonsoft.Json;

namespace InvisibleCollectorLib.Model
{
    /// <summary>
    ///     The debt model
    /// </summary>
    public class Debt : AttributesModel<Item>, IRoutableModel
    {
        internal const string AttributesName = "attributes";
        internal const string CurrencyName = "currency";
        internal const string CustomerIdName = "customerId";
        internal const string DateName = "date";
        internal const string DueDateName = "dueDate";
        internal const string ExpiresAtName = "expiresAt";
        internal const string GrossTotalName = "grossTotal";
        internal const string IdName = "id";
        internal const string ItemsName = "items";
        internal const string NetTotalName = "netTotal";
        internal const string PaidTotalName = "paidTotal";
        internal const string DebitTotalName = "debitTotal";
        internal const string CreditTotalName = "creditTotal";
        internal const string NumberName = "number";
        internal const string StatusName = "status";
        internal const string TaxName = "tax";
        internal const string TypeName = "type";

        /// <summary>
        ///     The currency. Must be an ISO 4217 currency code.
        /// </summary>
        public string Currency
        {
            get => GetField<string>(CurrencyName);

            set => this[CurrencyName] = value;
        }

        /// <summary>
        ///     The Id of the customer to whom the debt is issued.
        /// </summary>
        /// <remarks>
        ///     It must be the customer's <see cref="Customer.Id" /> itself and not the <see cref="Customer.ExternalId" />
        /// </remarks>
        /// <seealso cref="SetCustomerId" />
        public string CustomerId
        {
            get => GetField<string>(CustomerIdName);

            set => this[CustomerIdName] = value;
        }

        /// <summary>
        ///     The debt date. Only the years, month and days are considered.
        /// </summary>
        public DateTime? Date
        {
            get => GetField<DateTime?>(DateName);

            set => this[DateName] = value;
        }

        /// <summary>
        ///     The debt due date. Only the years, month and days are considered.
        /// </summary>
        public DateTime? DueDate
        {
            get => GetField<DateTime?>(DueDateName);

            set => this[DueDateName] = value; // datetime is immutable
        }

        /// <summary>
        ///     The debt due date. Only the years, month and days are considered.
        /// </summary>
        public DateTime? ExpiresAt
        {
            get => GetField<DateTime?>(ExpiresAtName);

            set => this[ExpiresAtName] = value; // datetime is immutable
        }

        public double? GrossTotal
        {
            get => GetField<double?>(GrossTotalName);

            set => this[GrossTotalName] = value;
        }

        [JsonProperty(IdName)]
        public string Id
        {
            get => GetField<string>(IdName);

            set => this[IdName] = value;
        }

        public IList<Item> Items
        {
            get => InternalItems?.Clone(); // deep copy

            set => InternalItems = value?.Clone();
        }

        public double? NetTotal
        {
            get => GetField<double?>(NetTotalName);

            set => this[NetTotalName] = value;
        }

        public double? PaidTotal
        {
            get => GetField<double?>(PaidTotalName);

            set => this[PaidTotalName] = value;
        }

        public double? DebitTotal
        {
            get => GetField<double?>(DebitTotalName);

            set => this[DebitTotalName] = value;
        }

        public double? CreditTotal
        {
            get => GetField<double?>(CreditTotalName);

            set => this[CreditTotalName] = value;
        }

        public string Number
        {
            get => GetField<string>(NumberName);

            set => this[NumberName] = value;
        }

        /// <summary>
        ///     The debt status. Can be one of: "PENDING" - the default value; "PAID"; "CANCELLED"
        /// </summary>
        public string Status
        {
            get => GetField<string>(StatusName);

            set => this[StatusName] = value;
        }

        /// <summary>
        ///     The total amount being paid in tax.
        /// </summary>
        public double? Tax
        {
            get => GetField<double?>(TaxName);

            set => this[TaxName] = value;
        }

        /// <summary>
        ///     The debt type. Can be one of: "FT", "FS", "SD"
        /// </summary>
        public string Type
        {
            get => GetField<string>(TypeName);

            set => this[TypeName] = value;
        }

        protected override IDictionary<string, string> InternalAttributes
        {
            get => GetField<IDictionary<string, string>>(AttributesName);

            set => this[AttributesName] = value;
        }

        protected override IList<Item> InternalItems
        {
            get => GetField<IList<Item>>(ItemsName);

            set => this[ItemsName] = value;
        }
        
        protected override string ItemName => ItemsName;


        public string RoutableId => Id;

        public void AddItem(Item item)
        {
            base.AddItem(item);
        }

        public override bool Equals(object other)
        {
            return other is Debt debt && this == debt;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Debt left, Debt right)
        {
            return AreEqual(left, right, ItemsName, AttributesName);
        }

        public static bool operator !=(Debt left, Debt right)
        {
            return !(left == right);
        }


        /// <summary>
        ///     A convenience method to set the customer id.
        /// </summary>
        /// <param name="customer">The customer</param>
        public void SetCustomerId(Customer customer)
        {
            CustomerId = customer.Id;
        }

        public void UnsetAttributes()
        {
            UnsetField(AttributesName);
        }

        public void UnsetCurrency()
        {
            UnsetField(CurrencyName);
        }

        public void UnsetCustomerId()
        {
            UnsetField(CustomerIdName);
        }

        public void UnsetDate()
        {
            UnsetField(DateName);
        }

        public void UnsetDueDate()
        {
            UnsetField(DueDateName);
        }

        public void UnsetExpiresAt()
        {
            UnsetField(ExpiresAtName);
        }

        public void UnsetGrossTotal()
        {
            UnsetField(GrossTotalName);
        }

        public void UnsetId()
        {
            UnsetField(IdName);
        }

        public void UnsetItems()
        {
            UnsetField(ItemsName);
        }

        public void UnsetNetTotal()
        {
            UnsetField(NetTotalName);
        }

        public void UnsetPaidTotal()
        {
            UnsetField(PaidTotalName);
        }

        public void UnsetDebitTotal()
        {
            UnsetField(DebitTotalName);
        }

        public void UnsetCreditTotal()
        {
            UnsetField(CreditTotalName);
        }

        public void UnsetNumber()
        {
            UnsetField(NumberName);
        }

        public void UnsetStatus()
        {
            UnsetField(StatusName);
        }

        public void UnsetTax()
        {
            UnsetField(TaxName);
        }

        public void UnsetType()
        {
            UnsetField(TypeName);
        }

        public override string ToString()
        {
            var fields = FieldsShallow;
            fields[ItemsName] = InternalItems?.StringifyList();
            fields[AttributesName] = InternalAttributes?.StringifyDictionary();
            return fields.StringifyDictionary();
        }
    }
}
