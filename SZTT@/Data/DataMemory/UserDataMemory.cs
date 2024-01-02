using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SZTT_.Data.Common;

namespace SZTT_.Data.DataMemory
{
    public class UserDataMemory : IUserStorage
    {

        public UserDataMemory() { }
        public string GetUserName(int userID)
        {
            if (userID == 747474)
            {
                return "Adam";
            }
            return "hiBALINTs";
        }
    }
}
