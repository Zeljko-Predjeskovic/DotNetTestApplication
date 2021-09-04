using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pre.WebApplication.Models
{
    public class UserList
    {
        public List<User> userList { get; } = new List<User>();

        public UserList() {

            userList.Add(new User() { Name = "Zeljko" , age = 21 });
            userList.Add(new User() { Name = "Zeljko", age = 21 });
            userList.Add(new User() { Name = "Zeljko3", age = 20 });
            userList.Add(new User() { Name = "Zeljko3", age = 21 });
            userList.Add(new User() { Name = "Zeljko5", age = 22 });
            userList.Add(new User() { Name = "Zeljko6", age = 19 });




        }
    }
}
