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
        private List<MenuItem> m_SubMenuItemsList = new List<MenuItem>();
        public event Action Chosen;

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
            m_SubMenuItemsList.Add(subMenuItem);
            return subMenuItem;
        }

        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine(m_MenuTitle);
            Console.WriteLine("0. " + (m_ParentMenuItem == null ? "Exit" : "Back"));
            for (int i = 0; i < m_SubMenuItemsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {m_SubMenuItemsList[i].m_MenuTitle}");
            }
        }

        public MenuItem GetSubMenuItem(int i_UserChoice)
        {
            return m_SubMenuItemsList[i_UserChoice - 1];
        }

        public bool IsLeaf()
        {
            return m_SubMenuItemsList.Count == 0;
        }

        public int AmountOfChoices()
        {
            return m_SubMenuItemsList.Count;
        }

        protected virtual void OnItemWasChosen()
        {
            if (Chosen != null)
            {
               Chosen.Invoke(); 
            }
        }

        public void MenuItemWasChosen()
        {
            Console.Clear();
            OnItemWasChosen();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
    }
}
