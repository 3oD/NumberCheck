using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class function
    {
        public void AnalyseZahl(string str)
        {
            ///check input for integer:
            ///     if so, set global variable bNumber true
            ///     else, set bNumber false
            try
            {
                float number = float.Parse(str);
                Globals.bNumber = true;
            }
            catch (FormatException)
            {
                Globals.bNumber = false;
            }
            
        }
    }
}
