using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private string m_MenuTitle;
        private MenuItem m_ParentMenuItem;
        private List<MenuItem> m_MenuItemsList = new List<MenuItem>();

        public MenuItem ParentMenuItem
        {
            get
            {
                return m_ParentMenuItem;
            }
        }

        public MenuItem(string i_MenuItemTitle, MenuItem i_ParentMenuItem)
        {
            m_MenuTitle = i_MenuItemTitle;
            m_ParentMenuItem = i_ParentMenuItem;
        }

        public MenuItem AddSubMenuItem(string i_MenuItemTitle)
        {
            MenuItem subMenuItem = new MenuItem(i_MenuItemTitle, this);
            m_MenuItemsList.Add(subMenuItem);
            return subMenuItem;
        }

        public void PrintMenu()
        {

        }

        public MenuItem GetSubMenuItem(int i_UserChoice)
        {
            return m_MenuItemsList[i_UserChoice - 1];
        }

        public bool IsLeaf()
        {
            return m_MenuItemsList.Count == 0;
        }

        public int AmountOfChoices()
        {
            return m_MenuItemsList.Count;
        }

        public void Chosen()
        {

        }
    }
}
