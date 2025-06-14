using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_8
{
    internal class Order
    {
        protected int orderNumber;

        protected int amount;

        public Order(int orderNumber, int amount)
        {
            this.orderNumber = orderNumber;
            this.amount = amount;
        }

        public virtual int getOrderNumber()
        { 
            return orderNumber;
        }

        public virtual int getAmount()
        {
            return amount;
        }

        public virtual void setAmount(int amount)
        {
            this.amount = amount;
        }

        public virtual string Delivery()
        {
            return "Standard order delivery";
        }

        public virtual string Payment(int amount)
        {
            if (amount == this.amount)
            {
                return "Payment successful";
            }
            return "Payment error";
        }
    }
}
