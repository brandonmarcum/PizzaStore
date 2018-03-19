using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class UserHelper
    {
        private List<Order> _order = new List<Order>();
        private List<User> _user = new List<User>();

        public void AddOrder(Order order)
        {
            _order.Add(order);
        }
        public void AddUser(User user)
        {
            _user.Add(user);
        }


    }
}
