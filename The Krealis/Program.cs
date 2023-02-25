using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_CSh_Windows_Forms
{
    static class Program
    {
        public static bool isGameStarted = false;
        public static string playerName;
        public static int playerClass; //0 - Mage, 1 - Warrior, 2 - Archer

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
            Menu menu = new Menu();
            playerName = menu.playerName;
            playerClass = menu.playerClass;
            Application.Run(new Gameplay());
        }
    }
}
