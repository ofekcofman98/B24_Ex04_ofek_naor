using Ex04.Menus.Test.ItemsListeners;

namespace Ex04.Menus.Test
{
    internal class InterfaceMenu
    {
        public static Interfaces.MainMenu CreateInterfaceMainMenu()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Interface Main Menu");
            Interfaces.MenuItem versionAndCapitalsMenuItem = mainMenu.AddSubMenuItem("Version and Capitals");
            Interfaces.MenuItem dateAndTimeMenuItem = mainMenu.AddSubMenuItem("Show Date/Time");

            Interfaces.MenuItem showVersion = versionAndCapitalsMenuItem.AddSubMenuItem("Show Version");
            Interfaces.MenuItem showCapitals = versionAndCapitalsMenuItem.AddSubMenuItem("Count Capitals");

            Interfaces.MenuItem showDate = dateAndTimeMenuItem.AddSubMenuItem("Show Date");
            Interfaces.MenuItem showTime = dateAndTimeMenuItem.AddSubMenuItem("Show Time");

            showVersion.RegisterListener(new ShowVersion());
            showCapitals.RegisterListener(new CountCapitals());
            showDate.RegisterListener(new ShowDate());
            showTime.RegisterListener(new ShowTime());

            return mainMenu;
        }
    }
}