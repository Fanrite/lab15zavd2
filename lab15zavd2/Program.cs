using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace lab15zavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            string txt;

            txt = Interaction.InputBox("...", "Введіть текст: ", ".капец.");
            foreach (char num in txt)
            {
                if (num == '.') output += $"...";
                else output += num;
            }

            MessageBox.Show($"Оброблений рядок: {output}", "Результат", MessageBoxButtons.OK);
        }
    }
}
