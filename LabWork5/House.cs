using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5
{
    class House:Base,Inter
    {
        private double ploshad;

        public double Ploshad
        {
            get { return ploshad; }
            set { ploshad = value; }
        }

        public void Read(House[] houseAray, int num)
        {
            throw new NotImplementedException();
        }
    }
}
