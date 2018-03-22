using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class UserHelper
    {
        private Dictionary<int, Order> _orders = new Dictionary<int, Order>();
        private List<User> _user = new List<User>();

        public void AddOrder(Order order)
        {
            if (_orders.Count < 3)
                _orders.Add(GetOrders().Count, order);
        }
        public Dictionary<int,Order> GetOrders()
        {
            return _orders;
        }
        public void AddUser(User user)
        {
            _user.Add(user);
        }

        public double GetSumOfAllOrders()
        {
            double grandTotal = 0;
            for (int i = 0; i < GetOrders().Count; i++)
            {
                grandTotal = _orders[i].CalculateTotalCost(i);
            }

            if (grandTotal >= 500 || grandTotal < 0)
                throw new OverflowException("Cash value is out of range");


            Console.WriteLine(grandTotal);
            return grandTotal;
        }


    }
}
