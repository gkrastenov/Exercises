namespace MarketStore
{
    public abstract class Card
    {
        /// <summary>
        /// Gets or sets value of purchase.
        /// </summary>
        public decimal ValueOfPurchase { get; set; }

        /// <summary>
        /// Gets or sets calculated discount.
        /// </summary>
        public decimal Discount  { get; set; }

        /// <summary>
        /// Gets or sets information about its owner.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the turnover for the previous month.
        /// </summary>
        public decimal Turnover { get;  set; }

        /// <summary>
        /// Gets or sets initial discount rate.
        /// </summary>
        public double InitialDiscountRate { get; set; }

        /// <summary>
        /// Printing output.
        /// </summary>
        public abstract void Print();
    }
}
