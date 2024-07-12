using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InterfaceMenu
    {
        public static Interfaces.MainMenu CreateInterfaceMainMenu()
        {
            Interfaces.MainMenu mainMenu = new MainMenu("Interface Main Menu");
            MenuItem versionAndCapitalsMenuItem = mainMenu.AddSubMenuItem("Version and Capitals");
            MenuItem dateAndTimeMenuItem = mainMenu.AddSubMenuItem("Show Date/Time");

            versionAndCapitalsMenuItem.AddSubMenuItem("Show Version");
            versionAndCapitalsMenuItem.AddSubMenuItem("Show Capitals");

            dateAndTimeMenuItem.AddSubMenuItem("Show Date");
            dateAndTimeMenuItem.AddSubMenuItem("Show Time");

            return mainMenu;
        }
    }
}
