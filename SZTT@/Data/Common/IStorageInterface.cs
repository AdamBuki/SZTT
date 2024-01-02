using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Data.Common
{
    // ezen keresztuk valositjuk meg a stretegy mintat es a laza csatolast.
    public interface IStorageInterface
    {
        void AddCard(Card card);
        Card GetCardByName(string name);
        void RemoveCard(string name);
        IEnumerable<Card> GetAllCards();
        bool CardExists(string name);
    }
}
