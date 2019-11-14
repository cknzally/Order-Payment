using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRouge
{
    class Payment
    {
        #region Attributs
        private string name;
        private float amount;


        #endregion

        #region Properties
        public string Name

        {
            get { return name; }
            set { name = value; }
        }

        public float Amount

        {
            get { return amount; }
            set { amount = value; }
        }

        #endregion
    }
}
