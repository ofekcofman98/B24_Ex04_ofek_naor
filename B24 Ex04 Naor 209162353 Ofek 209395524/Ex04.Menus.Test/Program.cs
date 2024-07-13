namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            Interfaces.MainMenu interfacesMainMenu = InterfaceMenu.CreateInterfaceMainMenu();
            interfacesMainMenu.Show();

            Events.MainMenu eventsMainMenu = EventMenu.CreateEventMainMenu();
            eventsMainMenu.Show();
        }
    }
}
