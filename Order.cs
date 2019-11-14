using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRouge
{
    public class Order
    {
        #region Attributs
        private long  idOrder;
        private int quantity;
        private long idBike;
        private float sumFreetax;
        private DateTime date;
        private long idShop;
        private long idCustemer;
        private List<Payment> payMode;
        private float discount;
        private int loyaltyPoint;
        //private List<Payment> payMode;

       
       



        #endregion

        #region Properties 
        public long IdOrder
        {
            get { return idOrder; }
            set { idOrder = value; }
        }

        public int Quantity

        {
            get { return quantity; }
            set { quantity = value; }
        }

        public long IdBike

        {
            get { return idBike; }
            set { idBike = value; }
        }

        public float Sumfreetax

        {
            get { return sumFreetax; }
            set { sumFreetax = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public long IdShop

        {
            get { return idShop; }
            set { idShop = value; }
        }

        public long IdCustemer

        {
            get { return idCustemer; }
            set { idCustemer = value; }
        }

        public float Discount

        {
            get { return discount; }
            set { discount = value; }
        }

        public int LoyaltyPoint

        {
            get { return loyaltyPoint; }
            set { loyaltyPoint = value; }
        }

       

        #endregion
    }
}
