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
            //var hit = heighit.Text;
            //var wit = weighit.Text;
            try
            {
                /*double h = double.Parse(hit);
                if (h >= 100)
                {
                    h = h / 100;
                }
                double w = double.Parse(wit);
                double bmi = w / h / h;
                int bmi2 = (int)(bmi * 10);
                double bmi3 = (double)(bmi2 / 10.0);
                result.Text = "身長" + h + "m　体重" + w + "kgの人のBMIは" + bmi3 + "です。";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "もう一度入力してください。";
       
            }*/

        double height = Double.Parse(heighit.Text);
        double weight = Double.Parse(weighit.Text);
        double BMI = (height/ (weight * weight));
        Console.WriteLine(BMI);



        }
    }
}
