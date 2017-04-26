using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck {
    //This is a deck class. It has a list of card, a max number of cards
    List<Card> cards;

    public Deck()
    {
        cards = new List<Card>();
    }

    public void AddCard(Card card) { cards.Add(card); }
}
