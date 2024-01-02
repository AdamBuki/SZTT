using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTT_.Data.Common
{
    public interface IUserStorage
    { 
        string GetUserName(int userID);
    }
}
