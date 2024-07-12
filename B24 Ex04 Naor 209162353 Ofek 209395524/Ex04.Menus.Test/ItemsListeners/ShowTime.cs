using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IMenuItemListener
    {
        public void Invoke()
        {
            ItemsMethods.ShowTime();
        }
    }
}
