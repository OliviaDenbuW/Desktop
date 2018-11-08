using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uppgiftBankInlämning3
{
    public class Bank
    {
        public static void GetFile()
        {
            /*Vill spara raderna - Skapar först en tom lista
              När vi sedan börjar loopa så läggs respektive rad in i listan
              Lägger in raderna i listan så vi sen kan skriva ut dem - Via foreach loopen*/
            List<string> fullCustomerList = new List<string>();

            //string path = "C:\\Users\\Olivia\\Desktop\\Inlämning 3 - BANK\\bankdata.txt";
            string path = "C:\\Users\\Olivia\\Desktop\\Inlämning 3 - BANK\\bankdata.txt";

            StreamReader sr = new StreamReader(path);
            string fileRow; //variabel som vi ska plocka in datat i för varje rad

            /*Läs rader, rad för rad, tills textfilen är tom (alltså alla rader är lästa)
              Loopen körs lika många varv som det finns rader i filen*/
            while ((fileRow = sr.ReadLine()) != null)
            {
                fileRow = sr.ReadLine();
                Console.WriteLine(fileRow);
            }
            sr.Close();
        }
    }
}
