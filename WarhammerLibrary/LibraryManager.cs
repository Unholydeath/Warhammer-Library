using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Warhammer10thEdition;

namespace WarhammerLibrary
{
    public class LibraryManager
    {
        private Dictionary<string, Army> armyDictionary;
        private FileReader reader;

        private void PrintIntro()
        {
            System.Console.WriteLine("-----------Warhammer Library--------");
            System.Console.WriteLine();
            System.Console.WriteLine("Welcome to the Warhammer Library!");
            System.Console.WriteLine("I will now load the contents for 10th edition");
        }

        private void PrintFiles()
        {
            System.Console.WriteLine("Here's the current contents of the library:");

            foreach (Army army in armyDictionary.Values)
            {
                System.Console.WriteLine("We found an army named: " + army.Name + " which has " + army.Units.Count + " units and " + army.Detachments.Count + " detachments in it.");
            }
        }
        
        public LibraryManager()
        {            
            reader = new FileReader();
            armyDictionary = reader.GetFiles();
        }

        public void StartLibrary()
        {
            PrintIntro();
            PrintFiles();
            reader.SaveFiles(armyDictionary);
        }
    }
}
