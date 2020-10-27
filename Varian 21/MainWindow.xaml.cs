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

namespace Varian_21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int summ = rnd.Next(100, 900);
            Costil1.Text = summ + " ";
            Stoim.Content = (summ + "Руб.");
            Proverka.IsEnabled = true;
            summa1.IsEnabled = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string dengi1 = Convert.ToString(summa1.Text);
            int dengi = Convert.ToInt32(summa1.Text);
            int summ = Convert.ToInt32(Costil1.Text); 

            if (dengi == 0 || dengi > 0 ||dengi1 == " ")
            {
                Otvet.Content = "Некорректный ввод";
            }

            if (dengi == summ)
            {
                Otvet.Content = "Спасибо";
            }

            if (dengi > summ)
            {
                int zdacha = dengi - summ;
                Otvet.Content = ("Возьмите здачу - "+ zdacha);
            }

            if (dengi < summ)
            {
                int dobavka = summ - dengi;
                dobavka = dobavka * -1;
                Otvet.Content = "Недостаточно средств - "+dobavka;
            }

            Proverka.IsEnabled = false;
            summa1.IsEnabled = false;
        }

        private void Costil_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
