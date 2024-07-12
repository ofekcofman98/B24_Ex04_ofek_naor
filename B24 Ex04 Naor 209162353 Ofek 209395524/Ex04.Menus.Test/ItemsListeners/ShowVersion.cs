using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.ShowVersion();
        }
    }
}