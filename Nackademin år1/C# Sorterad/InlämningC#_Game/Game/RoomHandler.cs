using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class RoomHandler
    {
        ///<summary>
        ///List<Rooms> rooms
        ///</summary>
        ///<remarks>
        /// Detta är en lista med alla rummen som vi ska göra
        ///</remarks>
        List<Rooms> rooms = new List<Rooms>();
        List<Door> doors = new List<Door>();
       // int[,] map = new int[3, 3];
        //int[] mapCord = new[] { 0, 0 };
        

        //Rooms segment
        
        private void AddRooms()
        {

            rooms.Add(new Rooms() { name = "room 0,0", description = "test st5art", exits = new[] { 0, 0, 1, 2 }, itemRequrements = "key", doors = new[] { "wall", "door3", "wall", "door1" }, items = "nyckel", roomPlacement = new[] { 0, 0 } });
            rooms.Add(new Rooms() { name = "room 0,1", description = "Ett Mörkt Rum", exits = new[] { 0, 0, 0, 0 }, items = "", doors = new[] { "wall", "door4", "door1", "door2" }, roomPlacement = new[] { 0, 1 } });
            rooms.Add(new Rooms() { name = "room 0,2", description = "Ett Ljust Rum", exits = new[] { 0, 0, 0, 0 }, items = "", doors = new[] { "wall", "door5", "door2", "wall" }, roomPlacement = new[] { 0, 2 } });

            rooms.Add(new Rooms() { name = "room 1,0", description = "test st5art", exits = new[] { 0, 0, 0, 0 }, itemRequrements = "key", doors = new[] { "door3", "door8", "wall", "door6" }, items = "testItem", roomPlacement = new[] { 1, 0 } });
            rooms.Add(new Rooms() { name = "room 1,1", description = "Ett Mörkt Rum", exits = new[] { 0, 0, 0, 0 }, items = "testItem", doors = new[] { "door4", "door9", "door6", "door7" }, roomPlacement = new[] { 1, 1 } });
            rooms.Add(new Rooms() { name = "roon 1,2", description = "Ett Ljust Rum", exits = new[] { 0, 0, 0, 0 }, items = "testItem", doors = new[] { "door5", "door10", "door7", "wall" }, roomPlacement = new[] { 1, 2 } });

            rooms.Add(new Rooms() { name = "room 2,0", description = "test st5art", exits = new[] { 0, 0, 0, 0 }, itemRequrements = "key", doors = new[] { "door8", "wall", "wall", "door11" }, items = "testItem", roomPlacement = new[] { 2, 0 } });
            rooms.Add(new Rooms() { name = "room 2,1", description = "Ett Mörkt Rum", exits = new[] { 0, 0, 0, 0 }, items = "testItem", doors = new[] { "door9", "wall", "door11", "door12" }, roomPlacement = new[] { 2, 1 } });
            rooms.Add(new Rooms() { name = "room 2,2", description = "Ett Ljust Rum", exits = new[] { 0, 0, 0, 0 }, items = "testItem", doors = new[] { "door10", "wall", "door12", "wall" }, roomPlacement = new[] { 2, 2 } });

        }
        private void PopulateListRooms()
        {
            if (rooms.Count == 0)
            {
                AddRooms();
            }
        }

        public void ShowRoom(int[] mapCord)
        {
            PopulateListRooms();
            int count = 0;
            int index = 0;
            //ska byta till indexOf men funkar inte
            foreach (var value in rooms)
            {
                //letar efter samma rum
                if (value.roomPlacement.SequenceEqual(mapCord))
                {
                    index = count;
                }
                count++;
            }

            Console.WriteLine(rooms[index].name);
            Console.WriteLine(rooms[index].description);
            Console.WriteLine(rooms[index].items);

        }

        public int[] ExitsThereIsInRoom(int[] mapCord)
        {
            PopulateListRooms();
            foreach (var value in rooms)
            {
                if (value.roomPlacement.SequenceEqual(mapCord))
                {
                    return value.exits;
                }

            }
            return null;
        }

        public string[] GetDoorsNameForRoom(int[] mapCord)
        {
            foreach (var value in rooms)
            {
                if (value.roomPlacement.SequenceEqual(mapCord))
                {
                    return value.doors;
                }
            }
            return null;
        }

        public void DropItem(string name,int[]mapCord)
        {
            int count = 0;
            foreach (var value in rooms)
            {

                if (value.roomPlacement.SequenceEqual(mapCord))
                {
                    string tempString = rooms[count].items;
                    if (tempString.Length > 0)
                    {
                        tempString += " "+name ;
                        rooms[count].items = tempString;
                    }
                    else
                    {
                        rooms[count].items = name;

                    }
                }
                count++;
            }
            
        }

       // Doors Segment
        private void AddDoors()
        {
            doors.Add(new Door() { name = "door1", open = true, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });
            doors.Add(new Door() { name = "door2", open = true, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });

            doors.Add(new Door() { name = "door3", open = true, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel", });
            doors.Add(new Door() { name = "door4", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });

            doors.Add(new Door() { name = "door5", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });
            doors.Add(new Door() { name = "door6", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });

            doors.Add(new Door() { name = "door7", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });
            doors.Add(new Door() { name = "door8", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });
            doors.Add(new Door() { name = "door9", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "Key" });

            doors.Add(new Door() { name = "door10", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });
            doors.Add(new Door() { name = "door11", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });
            doors.Add(new Door() { name = "door12", open = false, description = "en massive dörr med ett nycket hål", keyRecurement = "nyckel" });
        }
        public void PopulateDoorList()
        {
            if (doors.Count == 0)
            {
                AddDoors();
            }
        }

        public bool CanweWalkThru(string door)
        {
            foreach (var value in doors)
            {
                if (value.name == door)
                {
                    return value.open;
                }
            }
            return false;
        }

        public void OpenDoor(string door,int [] mapCords)
        {
            
        }







        //Items Segment

        public string PickupItem(string itemName, int[] mapCords)
        {
            int index = FindIdexItemName(itemName);

            if (rooms[index].roomPlacement.SequenceEqual(mapCords))
            {
                if (rooms[index].items.ToLower() == itemName)
                {
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("Du plocka upp " + rooms[index].items);
                    
                    rooms[index].items = "";

                    //om föremålet finns
                    return itemName;
                }
                else
                {
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("Det du leta efter fanns inte  ");
                    return null;
                }
            }
            return null;

            //om inte ska läggas till

        }
        //ska ändra så den kollar i inventory
      //  public void DropItem(string itemName, int[] mapCords)
      //  {
      //      int index = FindIdexItemName(itemName);
      //
      //      if (rooms[index].roomPlacement.SequenceEqual(mapCords))
      //      {
      //          if (rooms[index].items.ToLower() == itemName)
      //          {
      //              Console.SetCursorPosition(10, 10);
      //              Console.WriteLine("Du kasta  " + rooms[index].items +"på marken");
      //
      //              rooms[index].items = itemName;
      //
      //              //om föremålet finns
      //              
      //          }
      //          else
      //          {
      //              Console.SetCursorPosition(10, 10);
      //              Console.WriteLine("Du hade inte den saken på dig");
      //              
      //          }
      //      }
      //     
      //
      //      //om inte ska läggas till
      //  }

        public string ReturnItemRequrements(int[] mapCord)
        {
            foreach (var value in rooms)
            {
                if (value.roomPlacement.SequenceEqual(mapCord))
                {
                    return value.itemRequrements;
                }

            }
            return "none";
        }
        private int FindIdexItemName(string itemName)
        {
            int count = 0;
            int index = 0;
            foreach (var value in rooms)
            {
                ;
                if (value.name == itemName)
                {
                    index = count;

                }
                count++;

            }
            return index;
        }

    }

}
