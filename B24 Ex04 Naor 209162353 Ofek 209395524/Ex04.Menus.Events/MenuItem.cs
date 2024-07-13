using System;
using System.Collections.Generic;

namespace Ex04.Menus.Events
{
    public class MenuItem
    {
        private readonly string r_MenuTitle;
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
            r_MenuTitle = i_MenuItemTitle;
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
            Console.WriteLine($"**{r_MenuTitle}**");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < m_SubMenuItemsList.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> {m_SubMenuItemsList[i].r_MenuTitle}");
            }

            Console.WriteLine("0 -> " + (m_ParentMenuItem == null ? "Exit" : "Back"));
            Console.WriteLine("------------------------------");
            Console.Write("Enter your request: (");

            for (int i = 1; i <= m_SubMenuItemsList.Count; i++)
            {
                Console.Write($"{i}");
                if (i < m_SubMenuItemsList.Count)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine($" or press '0' to {(m_ParentMenuItem == null ? "Exit" : "Back")}).");
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
            OnItemWasChosen();
            Console.WriteLine();
        }
    }
}
