using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var result = MessageBox.Show("Programista nie ponosi odpowiedzialności za błędy w Twoich podatkach. Czy akteptujesz zasady gry?",
             "Komunikat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Run(new Form1());
            } else
            {
                MessageBox.Show("Żeby korzystać z kalkulatora, musisz zaakceptować warunki postawione przez producenta!",
             "Fatal error znowu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
