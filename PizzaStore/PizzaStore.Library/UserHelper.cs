using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class UserHelper
    {
        private List<User> _user = new List<User>();

        
        public void AddUser(User user)
        {
            _user.Add(user);
        }
        public void UpdateUser(int index, User user)
        {
            _user[index] = user);
        }
        public void DeleteUser(int index)
        {
            _user.RemoveAt(index);
            for(int i = index; i < _user.Count; i++)
            {
                _user[i] = _user[i + 1];
            }
        }



    }
}
