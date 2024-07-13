using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCapitalsListener : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.CountCapitals();
        }
    }
}
