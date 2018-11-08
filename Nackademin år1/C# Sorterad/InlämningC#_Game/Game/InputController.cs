using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class InputController
    {
        ///<summary>
        /// Hanterar Spelet med run och items
        ///</summary>
        ///<remarks>
        ///GameHandler Game Kontaktar itemHandler och rooms för att se om saker finns
        ///</remarks>
        GameHandler Game = new GameHandler();

        ///<summary>
        ///inputCheck kollar om kommandot finns (byta till smidigare än massa if satser)
        ///</summary>    
        public void inputCheck(string UserInput)
        {
            if (UserInput.Contains("use"))
            {
                Console.WriteLine("Annändt föremål");
            }
            else if (UserInput.Contains("show"))
            {
                Game.ShowRoom();
            }
            else if (UserInput.Contains("inv"))
            {
                Game.ShowItems();
            }
            else if (UserInput.ToLower() == "w" || UserInput == "s" || UserInput == "a" || UserInput == "d")
            {
                            
                Game.MoveToNewRoom(UserInput);
                Game.ShowRoom();
                
                
            }
            else if (UserInput.Contains("inspect"))
            {
                string[] words = UserInput.Split(' ');
                try
                {
                    Game.CloseInspect(words[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
            else if (UserInput.Contains("drop"))
            {
                string[] words = UserInput.Split(' ');
                try
                {
                    Game.DropItem(words[1]);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
            else if (UserInput.Contains("get") )
            {
                string[] words = UserInput.Split(' ');
                try
                {
                    Game.PickUpItem(words[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
            else
            {
                Game.NoCommand();
            }
        }

        public void StartGame()
        {
            Game.StartGame();
            
        }
    }

}
