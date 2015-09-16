namespace finacialplanner
{
    internal class financial
    {

        public int years_val { get; set; }
        public double month_amount { get; set; }
        public double inital_amount { get; set; }
        public double running_amount { get; set; }
        public int y { get; set; }
        public double m { get; set; }
        public double yearly_return { get; set; }
        public int num { get; set; }
        private double rate { get; set; }

        //this is where the program decides whether to give a negitive return or a positive return
        public double calculate_rate (int num)
        {
            if (num <2)
            {
                rate = -0.00588;
            }

            if (num > 1)
            {
                //had to raise this number to get the avearge higher
                rate = 0.009;
            }
            return rate;
        }

        public double calculate_months (double run, double month, double rate)
        {
            running_amount = run + run * rate;
            running_amount = running_amount + month;

            return running_amount;
        }
        }

    }
