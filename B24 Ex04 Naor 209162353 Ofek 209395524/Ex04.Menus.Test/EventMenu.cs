namespace Ex04.Menus.Test
{
    public class EventMenu
    {
        public static Events.MainMenu CreateEventMainMenu()
        {
            Events.MainMenu mainMenu = new Events.MainMenu("Event Main Menu");

            Events.MenuItem versionAndCapitalsMenuItem = mainMenu.AddSubMenuItem("Version and Capitals");
            Events.MenuItem dateAndTimeMenuItem = mainMenu.AddSubMenuItem("Show Date/Time");

            Events.MenuItem showVersion = versionAndCapitalsMenuItem.AddSubMenuItem("Show Version");
            showVersion.Chosen += ItemsMethods.ShowVersion;

            Events.MenuItem showCapitals = versionAndCapitalsMenuItem.AddSubMenuItem("Count Capitals");
            showCapitals.Chosen += ItemsMethods.CountCapitals;

            Events.MenuItem showDate = dateAndTimeMenuItem.AddSubMenuItem("Show Date");
            showDate.Chosen += ItemsMethods.ShowDate;
            Events.MenuItem showTime = dateAndTimeMenuItem.AddSubMenuItem("Show Time");
            showTime.Chosen += ItemsMethods.ShowTime;

            return mainMenu;
        }
    }
}