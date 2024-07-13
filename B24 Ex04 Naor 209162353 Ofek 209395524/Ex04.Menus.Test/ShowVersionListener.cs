using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersionListener : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.ShowVersion();
        }
    }
}