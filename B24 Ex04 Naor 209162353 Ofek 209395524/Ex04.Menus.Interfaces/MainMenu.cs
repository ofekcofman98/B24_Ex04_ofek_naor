using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private MenuItem m_MainMenuItem;
        private MenuItem m_CurrentMenuItem;

        private const int k_Quit = 0;

        public MainMenu(string i_Title)
        {
            m_MainMenuItem = new MenuItem(i_Title, null);
            m_CurrentMenuItem = m_MainMenuItem;
        }

        public MenuItem AddSubMenuItem(string i_SubMenuItemTitle)
        {
            return m_MainMenuItem.AddSubMenuItem(i_SubMenuItemTitle);
        }

        public void Show()
        {
            bool isQuit = false;

            while(!isQuit)
            {
                m_CurrentMenuItem.PrintMenu();
                int userChoice = getMenuChoice(m_CurrentMenuItem);
                bool isMainMenu = m_CurrentMenuItem.ParentMenuItem == null;

                if (userChoice == k_Quit)
                {
                    if(isMainMenu)
                    {
                        isQuit = true;
                        continue;
                    }
                    else
                    {
                        m_CurrentMenuItem = m_CurrentMenuItem.ParentMenuItem;
                    }
                }
                else
                {
                    m_CurrentMenuItem = m_CurrentMenuItem.GetSubMenuItem(userChoice);

                    if(m_CurrentMenuItem.IsLeaf()) // change "Leaf"
                    {
                        m_CurrentMenuItem.Chosen();
                        m_CurrentMenuItem = m_CurrentMenuItem.ParentMenuItem;
                    }
                }
            }
        }

        private int getMenuChoice(MenuItem i_MenuItem)
        {
            while(true)
            {
                string userChoice = Console.ReadLine();

                try
                {
                    if(!int.TryParse(userChoice, out int choice))
                    {
                        throw new FormatException();
                    }
                    if (choice < 0 || choice > i_MenuItem.AmountOfChoices()) 
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    return choice;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format. Please enter a valid integer.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Choice out of range. Please enter a number between 0 and {i_MenuItem.AmountOfChoices()}.");
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please try again.");
                }
            }

        }
    }
}
