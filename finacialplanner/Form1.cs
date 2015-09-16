using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finacialplanner
{

    

    public partial class Form1 : Form
    {


        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if  (years.Text == null || monthlyAmount.Text == null || firstDeposit == null)
            {
                return;
            }

            financial financial_calc = new financial();

            financial_calc.years_val = int.Parse(years.Text);
            financial_calc.month_amount = double.Parse(monthlyAmount.Text);
            financial_calc.inital_amount = double.Parse(firstDeposit.Text);
            financial_calc.running_amount = financial_calc.inital_amount;
            financial_calc.y = 1;
            financial_calc.m = 1;

            listView1.Clear();

            listView1.Columns.Add("Year");
            listView1.Columns.Add("Amount");
            listView1.Columns.Add("Yearly Return");

            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = financial_calc.years_val;
            while (financial_calc.y <= financial_calc.years_val)
            {
                financial_calc.yearly_return = 0;
                financial_calc.m = 1;
                //starting loop for months 1 through 12
                while (financial_calc.m <= 12)
                {
                    
                    double real_rate = 0;
                    financial_calc.num = random.Next(1, 5);

                    real_rate = financial_calc.calculate_rate(financial_calc.num);
                    financial_calc.running_amount = financial_calc.calculate_months(financial_calc.running_amount, financial_calc.month_amount, real_rate);
                    financial_calc.yearly_return = financial_calc.yearly_return + real_rate;

                    financial_calc.m++;
                }

                progressBar1.Value = financial_calc.y;

                listView1.Items.Add(new ListViewItem(new string[] { financial_calc.y.ToString(), financial_calc.running_amount.ToString(), financial_calc.yearly_return.ToString() }));
                financial_calc.y++;

            }
            return;
        

        }
    }

    
}
