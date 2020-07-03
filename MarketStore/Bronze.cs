namespace MarketStore
{
    using System;

    public class Bronze : Card, ICalculate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bronze"/> class.
        /// </summary>
        public Bronze(decimal turnover, decimal value)
        {
            this.Turnover = turnover;
            this.ValueOfPurchase = value;
            CalculatingDisctounRate();
            CalculatingDiscount();
        }

        public void CalculatingDiscount()
        {
            this.Discount = (this.ValueOfPurchase * (decimal)this.InitialDiscountRate) / 100;
        }

        public void CalculatingDisctounRate()
        {
            if (this.Turnover < 100)
            {
                this.InitialDiscountRate = 0.00;
            }

            if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                this.InitialDiscountRate = 1.00;
            }

            if (this.Turnover > 300)
            {
                this.InitialDiscountRate = 2.50;
            }
        }

        public override void Print()
        {
            // Value of Purchase output
            Console.WriteLine("$" + string.Format("{0:0.00}", this.ValueOfPurchase));

            // Discount Rate output
            Console.WriteLine(string.Format("{0:0.0}", this.InitialDiscountRate) + "%");

            // Discount output
            Console.WriteLine("$" + string.Format("{0:0.00}", this.Discount));

            // Total output
            Console.WriteLine("$" + string.Format("{0:0.00}", this.ValueOfPurchase - this.Discount));
        }
    }
}
