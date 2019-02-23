using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class MBox
    {
        //Welcome Message
        public static void InfoBox()
        {
            MessageBoxResult result = MessageBox.Show("Hallo, willkommen zu meinem ersten Programm. Gib im " +
                "Textfeld einfach etwas ein und es wird überprüft, ob es eine Zahl ist. " +
                "Wenn nicht, dann bekommst du die entsprechende Fehlermeldung. \n" +
                "Und damit wünsche ich dir " +
                "viel Spaß", "Willkommen", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //User Choice
        public static void Choice()
        {
           // MessageBoxResult result = MessageBox.Show("Möchtest du eine lange Eingabe oder eine Eingabe mit Dezimalstellen prüfen?", "Du hast die Wahl", MessageBoxButton.);
        }

        //validate without input Message
        public static void NoInput()
        {
            MessageBoxResult result = MessageBox.Show("Bitte gib eine Zahl ein, bevor du auf OK klickst.",
                                      "Fehler!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        //wrong input Message
        public static void NotANumber()
        {
            MessageBoxResult result = MessageBox.Show("Danke. 6, setzen!", "Fehler!",
                                      MessageBoxButton.OK, MessageBoxImage.Error);
        }

        //Insider Message
        public static void FortyTwo()
        {
            MessageBoxResult result = MessageBox.Show("Ja Ja, die Lösung auf alles",
                "42", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //Right Input Message
        public static void Congratulations()
        {
            MessageBoxResult result = MessageBox.Show("Wunderbar, du hast eine Zahl eingegeben",
                                      "Herzlichen Glückwunsch!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
