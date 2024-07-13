using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateListener : IMenuItemListener
    {
        public void Invoke()
        {
           ItemsMethods.ShowDate();
        }
    }
}
