using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class InStoreOrder : Order
    {
        public InStoreOrder(int orderNumber, int amount) : base(orderNumber, amount) { }

        public override int getOrderNumber()
        {
            return orderNumber;
        }

        public override int getAmount()
        {
            return amount;
        }

        public override void setAmount(int amount)
        {
            this.amount = amount;
        }

        public override string Delivery()
        {
            return "In store order delivery";
        }

        public override string Payment(int amount)
        {
            if (amount == this.amount)
            {
                return "Payment successful";
            }
            return "Payment error";
        }
    }
}
