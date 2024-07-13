using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.ItemsListeners
{
    public class ShowVersion : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.ShowVersion();
        }
    }
}