﻿using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDateListener : IMenuItemListener
    {
        void IMenuItemListener.Invoke()
        {
           ItemsMethods.ShowDate();
        }
    }
}
