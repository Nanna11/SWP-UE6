using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class User
    {
        public User(string name)
        {
            _Name = name;
        }
        string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }
        }
    }
}
