using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test.ItemsListeners
{
    public class ShowDate : IMenuItemListener
    {
        public void Invoke()
        {
           ItemsMethods.ShowDate();
        }
    }
}
