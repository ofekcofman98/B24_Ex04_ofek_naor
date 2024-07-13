using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Events;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            //Interfaces.MainMenu interfacesMainMenu = InterfaceMenu.CreateInterfaceMainMenu();
            //interfacesMainMenu.Show();

            Events.MainMenu eventsMainMenu = EventMenu.CreateMainMenu();
            eventsMainMenu.Show();
        }
    }
}
