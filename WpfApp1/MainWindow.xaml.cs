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


namespace WpfApp1
{
    /*
     * @class Globals
     * globale Variablen
     */
    public static class Globals
    {
        /// <summary>
        /// bNumber = true, if input is integer
        /// 
        /// lNumber = true, if users choice is long number
        /// lNumber = false, if users choice is float number
        /// </summary>
        public static bool bNumber;
        public static bool lNumber;
    }
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MBox.InfoBox();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e) => Environment.Exit(1);

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            function functionIn = new function();
            string str = Zahl_Textbox.Text;
            ///validate Input
            functionIn.AnalyseZahl(str);

            ///Output Messages...Start
            if (Globals.bNumber && str == "42")
            {
                MBox.FortyTwo();
                output.Text = "Nerd!";
            }
            else if (Globals.bNumber && str != string.Empty)
            {                
                output.Text = str + " ist eine Zahl";
                MBox.Congratulations();
            }
            else if (!Globals.bNumber && str != string.Empty)
            {
                output.Text = str + " ist keine Zahl. kannst du nicht lesen?";
                MBox.NotANumber();
            }

            else
            {
                MBox.NoInput();
            }
            ///Output Messages...End

            ///clear text fiel after check
            str = string.Empty;
        }

        private void Zahl_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
