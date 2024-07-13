namespace Ex04.Menus.Test
{
    public class InterfaceMenu
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

            showVersion.RegisterListener(new ShowVersionListener());
            showCapitals.RegisterListener(new CountCapitalsListener());
            showDate.RegisterListener(new ShowDateListener());
            showTime.RegisterListener(new ShowTimeListener());

            return mainMenu;
        }
    }
}