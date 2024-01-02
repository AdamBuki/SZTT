using Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Data.Database
{
    public class DatabaseStorage : IStorageInterface
    {
        public void AddCard(Card card)
        {
            throw new NotImplementedException();
        }

        public bool CardExists(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Card> GetAllCards()
        {
            throw new NotImplementedException();
        }

        public Card GetCardByName(string name)
        {
            throw new NotImplementedException();
        }

        public void RemoveCard(string name)
        {
            throw new NotImplementedException();
        }
    }
}
