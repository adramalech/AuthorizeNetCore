using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class TransactionRequest
    {
        /// <summary>
        /// Type of credit card transaction.
        /// </summary>
        [JsonPropertyName("transactionType")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Amount of this transaction.  This is the total amount and must include tax,
        /// shipping, tips, and any other charges.
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Contains payment information.
        /// </summary>
        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }
        
        /// <summary>
        /// If enabled will create a customer profile from the data sent to make the transaction.
        /// </summary>
        [JsonPropertyName("profile")]
        public CustomerProfile Profile { get; set; }

        /// <summary>
        /// Contains information about the software that generated the transaction.
        /// </summary>
        [JsonPropertyName("solution")]
        public PartnerSolution Solution { get; set; }

        /// <summary>
        /// The merchant's in-store terminal number. Can identify the cashiers or kisks used.
        /// 
        /// Do not use your processor's terminal ID for this field.
        /// </summary>
        [JsonPropertyName("terminalNumber")]
        public string TerminalNumber { get; set; }

        /// <summary>
        /// Contains information about the order.
        /// </summary>
        [JsonPropertyName("order")]
        public Order Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tax")]
        public Tax Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("duty")]
        public Duty Duty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The merchant-assigned pruchase order number.
        /// </summary>
        [JsonPropertyName("poNumber")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The customer information.
        /// </summary>
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// The billing address information.
        /// </summary>
        [JsonPropertyName("billTo")]
        public CustomerContact BillTo { get; set; }

        /// <summary>
        /// The shipping address information.
        /// </summary>
        [JsonPropertyName("shipTo")]
        public CustomerContact ShipTo { get; set; }

        /// <summary>
        /// The IPv4 address of the customer initiating the transaction. 
        /// Defaults to 255.255.255.255 if not included in your request.
        /// </summary>
        [JsonPropertyName("customerIP")]
        public string CustomerIP { get; set; }

        /// <summary>
        /// Contains retail information.
        /// </summary>
        [JsonPropertyName("retail")]
        public Retail Retail { get; set; }

        /// <summary>
        /// Merchant-assigned employee ID.
        /// </summary>
        [JsonPropertyName("employeeId")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Contains one or more transaction setting.
        /// </summary>
        [JsonPropertyName("transactionSettings")]
        public TransactionSettings TransactionSettings { get; set; }

        /// <summary>
        /// These elements may be used to pass through information,
        /// such as session IDs and order details.  The merchant will
        /// receive these elements in the response, exactly as it was
        /// submitted in the request.
        /// </summary>
        [JsonPropertyName("userFields")]
        public UserFields UserFields { get; set; }

        /// <summary>
        /// Used to record payment card surcharges that are passed along to cusotmers.
        /// 
        /// Current supported for TSYS merchants.
        /// </summary>
        [JsonPropertyName("surcharge")]
        public Surcharge Surcharge { get; set; }

        /// <summary>
        /// Provides the option to submit a soft descriptor that will appear on the 
        /// carholder's statement after settlement.
        /// 
        /// Currently supported for TSYS merchants.
        /// </summary>
        [JsonPropertyName("merchantDescriptor")]
        public string MerchantDescriptor { get; set; }

        /// <summary>
        /// The amount of the tip authorized by the cardholder.
        /// 
        /// The total transaction amount must include this value.
        /// </summary>
        [JsonPropertyName("tip")]
        public decimal Tip { get; set; }
    }
}