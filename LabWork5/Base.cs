using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork5
{
    public class Base : Abstr
    {
        /// <summary>
        /// фамилия владельца дома
        /// </summary>
        private String vladelec;

        public String Vladelec
        {
            get { return vladelec; }
            set { vladelec = value; }
        }
    }
}
