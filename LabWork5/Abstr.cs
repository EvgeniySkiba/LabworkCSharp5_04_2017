using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5
{
    /// <summary>
    /// 
    /// </summary>
    public class Abstr
    {
        public void Poisk(House[] houseAray, int num, String fName)
        {            
            bool wasFound = false;

            for (int i = 0; i < num; i++)
            {
                // поиск по фамилии 
                if (houseAray[i].Vladelec == fName)
                {
                    Console.WriteLine("Found:  {0} : {1}", i + 1, fName);                  
                    wasFound = true;
                }
            }

            // если не найдено 
            if (!wasFound)
                Console.WriteLine("Vladeletc didn' t found");
        }
    }
}
