using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTimeListener : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.ShowTime();
        }
    }
}
