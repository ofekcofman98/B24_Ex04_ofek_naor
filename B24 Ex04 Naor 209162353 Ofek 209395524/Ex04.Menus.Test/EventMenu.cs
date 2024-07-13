using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Events;


namespace Ex04.Menus.Test
{
    public class EventMenu
    {
        public static Events.MainMenu CreateMainMenu()
        {
            Events.MainMenu mainMenu = new Events.MainMenu("Event Main Menu");

            Events.MenuItem versionAndCapitalsMenuItem = mainMenu.AddSubMenuItem("Version and Capitals");
            Events.MenuItem dateAndTimeMenuItem = mainMenu.AddSubMenuItem("Show Date/Time");

            Events.MenuItem showVersion = versionAndCapitalsMenuItem.AddSubMenuItem("Show Version");
            showVersion.Chosen += ItemsMethods.ShowVersion;

            Events.MenuItem showCapitals = versionAndCapitalsMenuItem.AddSubMenuItem("Count Capitals");
            showCapitals.Chosen += ItemsMethods.CountCapitals;

            Events.MenuItem showDate = dateAndTimeMenuItem.AddSubMenuItem("Show date");
            showDate.Chosen += ItemsMethods.ShowDate;
            Events.MenuItem showTime = dateAndTimeMenuItem.AddSubMenuItem("Show time");
            showTime.Chosen += ItemsMethods.ShowTime;

            return mainMenu;
        }
    }
}