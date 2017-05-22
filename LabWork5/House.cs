using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5
{
    public class House : Base, Inter
    {
        private double ploshad;

        /// <summary>
        /// свойство для доступа
        /// </summary>
        public double Ploshad
        {
            get { return ploshad; }
            set { ploshad = value; }
        }

        public House() { }

        public House(String vladelec_, double ploshad_)
        {
            Vladelec = vladelec_;
            Ploshad = ploshad_;
        }

        /// <summary>
        /// ВВОД ДАННЫХ 
        /// </summary>
        /// <param name="houseAray"></param>
        /// <param name="num"></param>
        public void Read(House[] houseAray, int num)
        {
            int current = 0;
            do
            {
                Console.WriteLine("Enter  first name of vladelec: ");
                string vladelecitem = Console.ReadLine();
                Console.WriteLine("Enter ploshchad  : ");
                String ploshadStr  = Console.ReadLine();
                double  ploshchsad = Convert.ToDouble(ploshadStr);

                House houseItem = new House(vladelecitem, ploshchsad);
                houseAray[current] = houseItem;
                current++;
            } while (current < num);
        }
    }
}
