// Create a base class called Order, which has properties for the order number and purchase amount.
// Create derived classes: OnlineOrder and InStoreOrder.
// Each of these classes should have its unique properties and methods.
// Create several objects of both classes and display information about the orders.
//

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new OnlineOrder(123, 50);
            Order order2 = new InStoreOrder(55, 90);

            Console.WriteLine($"Online order:: " +
                $"Order number: {order1.getOrderNumber()} " +
                $"Amount: {order1.getAmount()} " +
                $"Payment: {order1.Payment(10)} " +
                $"Delivery: {order1.Delivery()} ");

            Console.WriteLine($"In store order:: " +
                $"Order number: {order2.getOrderNumber()} " +
                $"Amount: {order2.getAmount()} " +
                $"Payment: {order2.Payment(10)} " +
                $"Delivery: {order2.Delivery()}");
        }
    }
}