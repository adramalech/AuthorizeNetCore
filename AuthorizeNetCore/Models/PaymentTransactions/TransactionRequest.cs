using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class TransactionRequest
    {
        /// <summary>
        /// Type of credit card transaction.
        /// </summary>
        [JsonProperty(PropertyName = "transactionType")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Amount of this transaction.  This is the total amount and must include tax,
        /// shipping, tips, and any other charges.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Contains payment information.
        /// </summary>
        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; set; }
        
        /// <summary>
        /// If enabled will create a customer profile from the data sent to make the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public CustomerProfile Profile { get; set; }

        /// <summary>
        /// Contains information about the software that generated the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "solution")]
        public PartnerSolution Solution { get; set; }

        /// <summary>
        /// The merchant's in-store terminal number. Can identify the cashiers or kisks used.
        /// 
        /// Do not use your processor's terminal ID for this field.
        /// </summary>
        [JsonProperty(PropertyName = "terminalNumber")]
        public string TerminalNumber { get; set; }

        /// <summary>
        /// Contains information about the order.
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public Order Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tax")]
        public Tax Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "duty")]
        public Duty Duty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The merchant-assigned pruchase order number.
        /// </summary>
        [JsonProperty(PropertyName = "poNumber")]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// The customer information.
        /// </summary>
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// The billing address information.
        /// </summary>
        [JsonProperty(PropertyName = "billTo")]
        public CustomerContact BillTo { get; set; }

        /// <summary>
        /// The shipping address information.
        /// </summary>
        [JsonProperty(PropertyName = "shipTo")]
        public CustomerContact ShipTo { get; set; }

        /// <summary>
        /// The IPv4 address of the customer initiating the transaction. 
        /// Defaults to 255.255.255.255 if not included in your request.
        /// </summary>
        [JsonProperty(PropertyName = "customerIP")]
        public string CustomerIP { get; set; }

        /// <summary>
        /// Contains retail information.
        /// </summary>
        [JsonProperty(PropertyName = "retail")]
        public Retail Retail { get; set; }

        /// <summary>
        /// Merchant-assigned employee ID.
        /// </summary>
        [JsonProperty(PropertyName = "employeeId")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Contains one or more transaction setting.
        /// </summary>
        [JsonProperty(PropertyName = "transactionSettings")]
        public TransactionSettings TransactionSettings { get; set; }

        /// <summary>
        /// These elements may be used to pass through information,
        /// such as session IDs and order details.  The merchant will
        /// receive these elements in the response, exactly as it was
        /// submitted in the request.
        /// </summary>
        [JsonProperty(PropertyName = "userFields")]
        public UserFields UserFields { get; set; }

        /// <summary>
        /// Used to record payment card surcharges that are passed along to cusotmers.
        /// 
        /// Current supported for TSYS merchants.
        /// </summary>
        [JsonProperty(PropertyName = "surcharge")]
        public Surcharge Surcharge { get; set; }

        /// <summary>
        /// Provides the option to submit a soft descriptor that will appear on the 
        /// carholder's statement after settlement.
        /// 
        /// Currently supported for TSYS merchants.
        /// </summary>
        [JsonProperty(PropertyName = "merchantDescriptor")]
        public string MerchantDescriptor { get; set; }

        /// <summary>
        /// The amount of the tip authorized by the cardholder.
        /// 
        /// The total transaction amount must include this value.
        /// </summary>
        [JsonProperty(PropertyName = "tip")]
        public decimal Tip { get; set; }
    }
}