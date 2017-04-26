using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: here, finish the definition of Card, have an enumeration with general card types (material, magic...)
//another enumeration with all card types ? - I think it's better than just a name.


//Need to organize this. It's not the best at the moment.
public enum GeneralType
{
    Null, Magic, Material
};
//Null is the initiation type. It doesn't mean anything. It has to be changed.
public enum CardType
{
    Null, Fireball, Teleportation, Heal, Wood, Metal
}

public class Card {
    //This is an empty card class
    //It has a general type, a specific type (a name), and a power level.
    //NB: This is not a physical card. A physical card class will be made. It will have a Card member.

    private GeneralType generalType {
        get
        {
            return generalType;
        }
        set
        {
            generalType = value;
        }
    }

    private CardType cardType
    {
        get
        {
            return cardType;
        }
        set
        {
            cardType = value;
        }
    }

    private int powerLevel //For example a heal card of level 2 will heal 2x as much as one of level 1. For materials, power level = quality
    {
        get
        {
            return powerLevel;
        }
        set
        {
            powerLevel = value;
        }
    }

    public void IncreasePowerLevel(int pl)
    {
        powerLevel += pl;
    }

    public Card()
    {
        generalType = GeneralType.Null;
        cardType = CardType.Null;
        powerLevel = 0;
    }

    public Card(Card card)
    {
        generalType = card.generalType;
        cardType = card.cardType;
        powerLevel = card.powerLevel;
    }

    virtual public void Use() { }
    virtual public void UseOnPlayer(Player player) { } //Need to define player
    virtual public void UseOnTarget() { } //Need to define target a target. Maybe an Entity class ? Entity would regroup enemies, NPCs and other things I can't think of right now

    static public Card Fusion(Card firstCard, Card secondCard) { //change input to list?
        //TODO: implement this function.
        //This does not destroy the used cards. This need to be implemented elsewhere (at the fusion station for example)
        //This is a dummy

        Card newCard = new Card();

        if (firstCard.cardType == secondCard.cardType)
        {
            newCard = new Card(firstCard);
            newCard.IncreasePowerLevel(secondCard.powerLevel);
        }

        return newCard;
    }
}
