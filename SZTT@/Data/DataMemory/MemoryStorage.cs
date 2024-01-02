using Data.Common;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SZTT_.Logic;

namespace Data.DataMemory
{
    public class MemoryStorage : IStorageInterface
    {
        private List<Card> cards;
        public MemoryStorage()
        {
            cards = new List<Card>();
        }
        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public bool CardExists(string name)
        {
            return cards.Any(card => card.Name == name);
        }

        public IEnumerable<Card> GetAllCards()
        {
            return cards;
        }

        public Card GetCardByName(string name)
        {
            return cards.Find(match: c => c.Name == name);
        }

        public void RemoveCard(string name)
        {
            Card cardToRemove = GetCardByName(name);
            if (cardToRemove != null)
            {
                cards.Remove(cardToRemove);
            }
        }
    }
}
