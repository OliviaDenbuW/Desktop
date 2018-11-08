using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ItemHandler
    {
        ///<summary>
        ///List<item>Items Lista med alla items 
        /// List<string> itemsInventory är sakerna man har
        ///</summary>
        List<item>itemsInventoryList = new List<item>();
        // sånt som ska skickas tillbaka till gamehandler
        
        ///<summary>
        /// AddItems() Lägger till items i item listan
        ///</summary>
        public void AddItems()
        {

            itemsInventoryList.Add(new item(){itemName = "nyckel",have = false, closeInspection = "En gyllene nyckel",description = "I hörnet ser du en nyckel ligga"});
            itemsInventoryList.Add(new item(){itemName = "test2",have=true, closeInspection = "close test", description = "Detta är ett item" });
        }

        ///<summary>
        /// ListAllItems() Visar alla items i itemlistan
        ///</summary>
       
        // hmm ska ändra så man inte  lägget till
        public string ShowInventory()
        {
            PopulateItemList();
            //ska läggas in en koll på om saken redan finns                 
            string tempInv ="";
            foreach (var value in itemsInventoryList)
            {
                if (value.have)
                {
                    tempInv += value.itemName + " ";
                    return tempInv;
                }
               
            }
            return null;
        }

        //lägger till item till inventory
        public void AddItem(string name)
        {
            PopulateItemList();
            foreach (var value in itemsInventoryList)
            {
                if (value.itemName == name)
                {
                    value.have = true;
                }
            }
        }

        public void DropItem(string name)
        {
            PopulateItemList();
            foreach (var value in itemsInventoryList)
            {
                if (value.itemName == name)
                {
                    value.have = false;
                }
            }
        }

        public bool UseItem(string itemName)
        {
            int index = ItemListIndex(itemName);

            if (itemsInventoryList[index].have)
            {
                return true;
                //lägga in used item ?
            }
            else
            {
                return false;
            }

        }

        public string closeInspect(string name)
        {
            foreach (var value in itemsInventoryList)
            {
                if (value.itemName == name)
                {
                    return value.closeInspection;
                }
            }
            return null;
        }
        //Hämtar var itemet finns på för index.
        private int ItemListIndex(string itemName)
        {
            int index = 0;
            int count = 0;
            foreach (var value in itemsInventoryList)
            {
                if (value.itemName == itemName)
                {
                    index = count;
                }
                count++;
            }
            return index;
        }

        private void PopulateItemList()
        {
            if (itemsInventoryList.Count == 0)
            {
                AddItems();
            }
        }

    }
}
