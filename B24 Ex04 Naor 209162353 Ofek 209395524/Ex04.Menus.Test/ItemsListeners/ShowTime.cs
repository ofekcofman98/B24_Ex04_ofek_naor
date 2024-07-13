using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.ItemsListeners
{
    public class ShowTime : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.ShowTime();
        }
    }
}
