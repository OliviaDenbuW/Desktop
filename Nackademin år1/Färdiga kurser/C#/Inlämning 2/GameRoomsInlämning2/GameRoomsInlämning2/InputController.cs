using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRoomsInlämning2
{
    class InputController
    {
        public void InputCheck(string userInput)
        {
            if(userInput.Contains("use"))
            {
                Console.WriteLine("Already used item");
            }
            else if(userInput.Contains("show"))
            {
                //Game.ShowRoom();
                ShowRoom();
            }
            else if(userInput.Contains("inv"))
            {
                //Game.ShowItems();
                ShowItems();
            }
            else if((userInput.ToLower() == "w") || (userInput.ToLower() == "s") || (userInput.ToLower() == "a") || (userInput.ToLower() == "d"))
            {
                //Game.MoveToNewRoom(userInput);
                //Game.ShowRoom();
                MoveToNewRoom(userInput);
                ShowRoom();

            }
            else if(userInput.Contains("inspect")
            {
                string[] words = userInput.Split(' ');
                try
                {
                    //Game.CloseInspect(words[1]);
                    CloseInspect(words[1]);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else if(userInput.Contain("drop"))
            {
                string[] words = userInput.Split(' ');
                try
                {
                    //Game.DropItem(words[1]);
                    DropItem(words[1]);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }  
            }
            else if(userInput.Contains("get")
            {
                string[] words = userInput.Split(' ');
                try
                {
                    //Game.PickUpItem(words[1]);
                    PickUpItem(words[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                //Game.NoCommand();
                NoCommand();
            }
    }
}
