using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameHandler
    {
        ///<summary>
        ///Information om object och vad dom gör
        ///</summary>
        ///<remarks>
        /// MapHandler Map hanterar kartan och movement
        /// ItemHandler Items Hanterar items i spelet
        /// mapCords är för att skicka runt var man är
        ///</remarks>
        MapHandler Map = new MapHandler();
        List<string> inventory = new List<string>();
        ItemHandler Items = new ItemHandler();
        RoomHandler rooms = new RoomHandler();
        MapHandler mapObj = new MapHandler();
        private int[] mapCords = new []{0,0};
        int[,] map = new int[3,3];

        ///<summary>
        ///Startar stelet
        ///</summary>
        ///<remarks>
        /// Startar spelet
        ///</remarks>
        public void NoCommand()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Det komandot finns inte");
        }
        public void itemRequerments()
        {
            
        }
        public void StartGame()
        {
            
            
           
        }

        ///<summary>
        ///Visar Rummet
        ///</summary>
        ///<remarks>
        ///rooms.AddRooms(); Lägger till alla rum vi gjort
        /// rooms.FindRoom(mapCords); Hittar rätt run som vi är på
        ///</remarks>
        public void ShowRoom()
        {
            Console.SetCursorPosition(5, 5);
            
            rooms.ShowRoom(mapCords);
        }

        ///<summary>
        ///Uppdaterar Kartan (behövs?)
        ///</summary>
        public void UpdateMap()
        {

        }

        ///<summary>
        ///Flyttar spelarn gör kontroll om man kan flytta och skickar tebax cords
        ///</summary>
        ///<remarks>
        ///Hanterar om man kan flytta dit man vill och hanterar kartan
        ///</remarks>
        public void MoveToNewRoom(string InputFromPlayer)
        {

            mapCords = Map.MapMovement(InputFromPlayer,map,mapCords);
            mapObj.ShowPossition(mapCords);
        }

        ///<summary>
        /// Visar Tillängliga Items WIP
        ///</summary>
        ///<remarks>
        ///Ska kolla mot map cords och se om man är i ett rum items i 
        ///</remarks>
        public void ShowItems()
        {
          
            string itm = Items.ShowInventory();
            string[] words = itm.Split(' ');
            try
            {
                Console.SetCursorPosition(0,20);
                Console.WriteLine("Inventory");
                foreach (var value in words)
                {
                    Console.WriteLine(value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public void DropItem(string name)
        {
          //  string itm = Items.ShowInventory();
          //  foreach (var value in itm)
          //  {
          //      if (itm == value.ToString())
          //      {
                    Items.DropItem(name);
                    rooms.DropItem(name,mapCords);
                    
           //     }
           //         
           // }
        }

        public void CloseInspect(string name)
        {
           string closeinspect = Items.closeInspect(name);
            Console.SetCursorPosition(10,10);
            Console.WriteLine(closeinspect);
        }

        public void PickUpItem(string itemName)
        {


           string itemToInv=rooms.PickupItem(itemName, mapCords);
             Items.AddItem(itemToInv);
        }

      
    }
}
