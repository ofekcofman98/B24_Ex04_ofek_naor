using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitalsListener : IMenuItemListener
    {
        void IMenuItemListener.Invoke()
        {
            ItemsMethods.CountCapitals();
        }
    }
}
