using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5
{
    class Abstr
    {
        
        public void Poisk(House[] houseAray, int num,String fName)
        {
            int count = 0;
            for(int i = 0; i< num;i++)
            {

                // поиск по фамилии 
                if (houseAray[i].Vladelec == fName)
                {
                    Console.WriteLine("{0} : {1}", i + 1, fName);
                    count++;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}
