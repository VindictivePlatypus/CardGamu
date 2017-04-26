using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    //This is the player class. It has health, energy, a deck of cards, a hand of cards, and will have equipment and inventory too.
    private int health
    {
        get
        {
            return health;
        }
        set
        {
            health = value < 0 ? 0 : value;
        }
    }
    private int energy
    {
        get
        {
            return energy;
        }
        set
        {
            energy = value < 0 ? 0 : value;
        }
    }

    private Deck deck;
    
    public Player()
    {
        health = 100;
        energy = 100;
        deck = new Deck();
    }
}
