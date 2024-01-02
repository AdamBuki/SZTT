using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Common;
using Data.DataMemory;
using SZTT_.Data.DataMemory;
using SZTT_.Logic;

namespace Logic
{
    public class CardService
    {
        private readonly IStorageInterface storage;
        private readonly User user;

        public CardService(IStorageInterface storage, User user)
        {
            this.storage = storage;
            this.user = user;
        }

        public void AddCard(string name, string latinName, string description)
        {

            if (ValidateCardInput(name, description))
            {

                var card = new Card(name, latinName, description);

                storage.AddCard(card);
                LogManipulaton("hozzaadta", name);
            }else
            {
                Console.WriteLine("nem sikerult hozzaadni a kartyat");
            }
        }
        // a validalas
        private bool ValidateCardInput(string name, string description)
        {
            try { 
                if (name == null || name.Length < 4 )
                {
                    throw new CardValidationException("a nev nem lehet null vagy rovidebb mint 4 karakter");
                }
                if (storage.CardExists(name))
                {
                    throw new CardValidationException("mar letezik ilyen nevu kartya");
                }
                if (description.Length > 250)
                {
                    throw new CardValidationException("a leiras nem lehet rovidebb mint 250 karakter");
                }
            return true;
            }
            catch (CardValidationException e)
                {
                    Console.WriteLine(e.Message);
                }
            return false;
        }
        

        public IEnumerable<Card> GetAllCards()
        {
            return storage.GetAllCards();
        }

        public Card GetCardByName(string name)
        {
            LogManipulaton("lekerte", name);
            return storage.GetCardByName(name);
            
        }

        public void RemoveCard(string name)
        {
            storage.RemoveCard(name);
            LogManipulaton("torolte", name);
        }
        public void SetTypeByName(string name, AnimalType type)
        {
            var card = storage.GetCardByName(name);
            card.Type = type;
            LogManipulaton("beallitotta a tipusat", name);
        }
        private void LogManipulaton(string action, string cardname)
        {
               Console.WriteLine($"{user.GetUserName()} {action} a {cardname}");
        }
    }
}
