using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text= resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate2Dollar = Convert.ToDouble(rate2.Text);
            double sum2Dollar = Convert.ToDouble(sum2.Text);
            double res2Double = rate2Dollar * sum2Dollar;
            resSum2.Text = res2Double.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate3Dollar = Convert.ToDouble(rate3.Text);
            double sum3Dollar = Convert.ToDouble(sum3.Text);
            double res3Double = rate3Dollar * sum3Dollar;
            resSum3.Text = res3Double.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate4Dollar = Convert.ToDouble(rate4.Text);
            double sum4Dollar = Convert.ToDouble(sum4.Text);
            double res4Double = rate4Dollar * sum4Dollar;
            resSum4.Text = res4Double.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rate5Dollar = Convert.ToDouble(rate5.Text);
            double sum5 = 0.0254;
            double res5Double = rate5Dollar * sum5;
            resSum5.Text = res5Double.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rate6Dollar = Convert.ToDouble(rate6.Text);
            double sum6 = 0.3048;
            double res6Double = rate6Dollar * sum6;
            resSum6.Text = res6Double.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rate7Dollar = Convert.ToDouble(rate7.Text);
            double sum7 = 1609.34;
            double res7Double = rate7Dollar * sum7;
            resSum7.Text = res7Double.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rate8Dollar = Convert.ToDouble(rate8.Text);
            double sum8 = 1066.8;
            double res8Double = rate8Dollar * sum8;
            resSum8.Text = res8Double.ToString();
        }
    }
}
