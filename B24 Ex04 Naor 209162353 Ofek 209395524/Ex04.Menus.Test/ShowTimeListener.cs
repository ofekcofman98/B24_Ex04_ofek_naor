using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeListener : IMenuItemListener
    {
        void IMenuItemListener.Invoke()
        {
            ItemsMethods.ShowTime();
        }
    }
}
