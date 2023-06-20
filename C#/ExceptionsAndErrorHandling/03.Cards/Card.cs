using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Cards
{
    public class Card
    {
        private string face;
        private string suit;
        public List<string> Faces { get; private set; }
        public List<string> Suits { get; private set; }
        public string Face
        {
            get { return face; }
            set
            {
                if (!Faces.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                face = value;
            }
        }
        public string Suit
        {
            get { return suit; }
            set
            {
                if (!Suits.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                suit = value;
            }
        }
        public Card()
        {
            Faces = new List<string>()
            {//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
                "2", "3", "4", "5", "6",
                "7", "8", "9", "10", "J",
                "Q", "K", "A",
            };
            Suits = new List<string>()
            {//S (♠), H (♥), D (♦), C (♣)
                "S", "H", "D", "C",
            };
        }
        public override string ToString()
        {
            char currSuit = char.MinValue;
            if (suit == "S") currSuit = '\u2660';
            else if (suit == "H") currSuit = '\u2665';
            else if (suit == "D") currSuit = '\u2666';
            else if (suit == "C") currSuit = '\u2663';
            return $"[{face}{currSuit}]";
        }
        public Card CreateCard(string face, string suit)
        {
            Face = face;
            Suit = suit;
            return this;
        }
    }
}
