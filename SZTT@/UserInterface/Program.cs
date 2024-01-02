using Data.Common;
using Data.DataMemory;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SZTT_.Data.DataMemory;
using SZTT_.Logic;

namespace SZTT_.UserInterface
{
    public class Program
    {
        private static IStorageInterface Storage = new MemoryStorage();
        private static User User = User.GetInstance(new UserDataMemory());

        private static CardService cardService = new CardService(Storage , User);
        static void Main(string[] args)
        {
            cardService.AddCard("kutya", "canis", "ez egy kutya");
            PrintAllCards();
            cardService.AddCard("mac", "felis", "ez egy macska");
            PrintAllCards();
            cardService.AddCard("zebrafant", "ananas", "ez egy vicces allat");
            PrintAllCards();
            cardService.RemoveCard("zebrafant");
            PrintAllCards();
            cardService.SetTypeByName("kutya", AnimalType.Mammal);
            PrintAllCards();

        }

        static void PrintAllCards()
        {
            foreach (var card in cardService.GetAllCards())
            {
                Console.WriteLine($"{card.Name}#{card.LatinName}#{card.Type}#{card.Description}");
            }
            
        }
    }

}
