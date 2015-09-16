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


        public double calculate_rate (int num)
        {
            if (num <2)
            {
                rate = -0.00588;
            }

            if (num > 1)
            {
                rate = 0.00588;
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
