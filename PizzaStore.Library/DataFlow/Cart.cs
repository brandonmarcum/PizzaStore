using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Cart
    {
        private Dictionary<int, Order> _orders = new Dictionary<int, Order>();

        public void AddOrder(Order order)
        {
            if (_orders.Count < 3)
                _orders.Add(GetOrders().Count, order);
        }

        public void UpdateOrder(int index, Order order)
        {
            _orders[index] = order;
        }

        public void DeleteOrder(int index)
        {
            _orders.Remove(index);
            for (int i = index; i < _orders.Count - 1; i++)
            {
                _orders[i] = _orders[i + 1];
            }
        }

        public Dictionary<int, Order> GetOrders()
        {
            return _orders;
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
