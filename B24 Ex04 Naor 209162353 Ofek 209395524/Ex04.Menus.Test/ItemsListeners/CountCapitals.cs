using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.ItemsListeners
{
    public class CountCapitals : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.CountCapitals();
        }
    }
}
