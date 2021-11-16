using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A11 菅野　裕二";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var height = txtHeight.Text;
            var weight = txtWeight.Text;
            try
            {
                double h = double.Parse(height);
                if (h >= 100)
                {
                    h = h / 100;
                }
                double w = double.Parse(weight);
                double bmi = w / h / h;
                int bmi2 = (int)(bmi * 10);
                double bmi3 = (double)(bmi2 / 10.0);
                lblHeight.Text = "身長" + h + "　体重" + w + "の人のBMIは" + bmi3 + "です。";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                lblHeight.Text = "！！！";
       
            }
        }
    }
}
