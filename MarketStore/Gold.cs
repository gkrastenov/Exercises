namespace MarketStore
{
    using System;

    public class Gold : Card, ICalculate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gold"/> class.
        /// </summary>
        public Gold(decimal turnover, decimal value)
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
            this.InitialDiscountRate = 2.0;

            if (this.Turnover <= 0)
            {
                return;
            }

            double grows = (double)this.Turnover / 100;
            if (grows > 8)
            {
                this.InitialDiscountRate = 10.0;
                return;
            }

            Math.Floor(this.InitialDiscountRate + grows);
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
