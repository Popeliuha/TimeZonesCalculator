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

namespace Інтерфейс_3
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

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime dat = DateTime.Now;
            result.Text = dat.ToShortTimeString();

            var a = (int)slider.Value;
            int hours = dat.Hour;
            int mins = dat.Minute;
            int newHours = a + hours;
            string newDateTime;

            switch (newHours)
            {
                case (-1):
                    newHours = 0;
                    break;
                case (-2):
                    newHours = 23;
                    break;
                case (-3):
                    newHours = 22;
                    break;
                case (-4):
                    newHours = 21;
                    break;
                case (-5):
                    newHours = 20;
                    break;
                case (-6):
                    newHours = 19;
                    break;
                case (-7):
                    newHours = 18;
                    break;
                case (-8):
                    newHours = 17;
                    break;
                case (-9):
                    newHours = 16;
                    break;
                case (-10):
                    newHours = 15;
                    break;
                case (-11):
                    newHours = 14;
                    break;
                case (-12):
                    newHours = 13;
                    break;
                case (-13):
                    newHours = 12;
                    break;
                case (-14):
                    newHours = 11;
                    break;
                case (-15):
                    newHours = 10;
                    break;
                case (-16):
                    newHours = 9;
                    break;
                case (-17):
                    newHours = 8;
                    break;
                case (-18):
                    newHours = 7;
                    break;
                case (-19):
                    newHours = 6;
                    break;
                case (-20):
                    newHours = 5;
                    break;
                case (-21):
                    newHours = 4;
                    break;
                case (-22):
                    newHours = 3;
                    break;
                case (-23):
                    newHours = 2;
                    break;
                case (24):
                    newHours = 1;
                    break;
                default:
                    break;
            }

            if (mins % 10 == 1)
            {
                newDateTime = (newHours).ToString() + " година "+ mins.ToString() + " хвилина.";
            }
            else if ((mins % 10 == 2)|| (mins % 10 == 3)|| (mins % 10 == 4))
            {
                newDateTime = (newHours).ToString() + " година " + mins.ToString() + " хвилини.";
            }
            else
            {
                newDateTime = (newHours).ToString() + " година " + mins.ToString() + " хвилин.";
            }
            result.Text = " "+newDateTime.ToString();
        }

        private void Save_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show($"На часовому поясі " +(int) slider.Value+" - "+result.Text, "Збережено");
        }

        private void Reset_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            result.Text = null;
            slider.Value = 0;
        }

        private void Exit_Handler (object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void Help_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Оберіть необхідний часовий пояс, пересунувши слайдер, і натисніть клавішу \"Згенерувати\".", "Допомога");
        }

        private void About_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Автор: S U R R I. Авторські права збережено. Копіювання карається законом.", "Про програму");
        }
    }
}
