using Data.Common;
using Data.DataMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SZTT_.Data.Common;
using SZTT_.Data.DataMemory;

namespace SZTT_.Logic
{
    public class User
    {
        private readonly IUserStorage userStorage;
        public int Id { get; set; } = 747474;

        // Singleton minta
        private User(IUserStorage userStorage)
        {
            this.userStorage = userStorage;
        }
        private static User instance;
        public static User GetInstance(IUserStorage userStorage)
        {
            if (instance == null)
            {
                instance = new User(userStorage);
            }
            return instance;
        }
        public string GetUserName()
        {
            return userStorage.GetUserName(Id);
        }

        
    }
}


