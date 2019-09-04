using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsLib : MonoBehaviour
{
    public static CardsLib definitions;

    public Sprite aceClubs;
    public Sprite twoClubs;
    public Sprite threeClubs;
    public Sprite fourClubs;
    public Sprite fiveClubs;
    public Sprite sixClubs;
    public Sprite sevenClubs;
    public Sprite eightClubs;
    public Sprite nineClubs;
    public Sprite tenClubs;
    public Sprite jackClubs;
    public Sprite queenClubs;
    public Sprite kingClubs;
    public Sprite aceDiamonds;
    public Sprite twoDiamonds;
    public Sprite threeDiamonds;
    public Sprite fourDiamonds;
    public Sprite fiveDiamonds;
    public Sprite sixDiamonds;
    public Sprite sevenDiamonds;
    public Sprite eightDiamonds;
    public Sprite nineDiamonds;
    public Sprite tenDiamonds;
    public Sprite jackDiamonds;
    public Sprite queenDiamonds;
    public Sprite kingDiamonds;
    public Sprite aceHearts;
    public Sprite twoHearts;
    public Sprite threeHearts;
    public Sprite fourHearts;
    public Sprite fiveHearts;
    public Sprite sixHearts;
    public Sprite sevenHearts;
    public Sprite eightHearts;
    public Sprite nineHearts;
    public Sprite tenHearts;
    public Sprite jackHearts;
    public Sprite queenHearts;
    public Sprite kingHearts;
    public Sprite aceSpades;
    public Sprite twoSpades;
    public Sprite threeSpades;
    public Sprite fourSpades;
    public Sprite fiveSpades;
    public Sprite sixSpades;
    public Sprite sevenSpades;
    public Sprite eightSpades;
    public Sprite nineSpades;
    public Sprite tenSpades;
    public Sprite jackSpades;
    public Sprite queenSpades;
    public Sprite kingSpades;
    public Sprite joker;



    public List<CardObject> BuildDeck()
    {
        var UnshuffledDeck = new List<CardObject>();
        UnshuffledDeck.Add(new CardObject("Ace of Clubs", 1, aceClubs));
        UnshuffledDeck.Add(new CardObject("Two of Clubs", 2, twoClubs));
        UnshuffledDeck.Add(new CardObject("Three of Clubs", 3, threeClubs));
        UnshuffledDeck.Add(new CardObject("Four of Clubs", 4, fourClubs));
        UnshuffledDeck.Add(new CardObject("Five of Clubs", 5, fiveClubs));
        UnshuffledDeck.Add(new CardObject("Six of Clubs", 6, sixClubs));
        UnshuffledDeck.Add(new CardObject("Seven of Clubs", 7, sevenClubs));
        UnshuffledDeck.Add(new CardObject("Eight of Clubs", 8, eightClubs));
        UnshuffledDeck.Add(new CardObject("Nine of Clubs", 9, nineClubs));
        UnshuffledDeck.Add(new CardObject("Ten of Clubs", 10, tenClubs));
        UnshuffledDeck.Add(new CardObject("Jack of Clubs", 10, jackClubs));
        UnshuffledDeck.Add(new CardObject("Queen of Clubs", 10, queenClubs));
        UnshuffledDeck.Add(new CardObject("King of Clubs", 10, kingClubs));
        UnshuffledDeck.Add(new CardObject("Ace of Diamonds", 1, aceDiamonds));
        UnshuffledDeck.Add(new CardObject("Two of Diamonds", 2, twoDiamonds));
        UnshuffledDeck.Add(new CardObject("Three of Diamonds", 3, threeDiamonds));
        UnshuffledDeck.Add(new CardObject("Four of Diamonds", 4, fourDiamonds));
        UnshuffledDeck.Add(new CardObject("Five of Diamonds", 5, fiveDiamonds));
        UnshuffledDeck.Add(new CardObject("Six of Diamonds", 6, sixDiamonds));
        UnshuffledDeck.Add(new CardObject("Seven of Diamonds", 7, sevenDiamonds));
        UnshuffledDeck.Add(new CardObject("Eight of Diamonds", 8, eightDiamonds));
        UnshuffledDeck.Add(new CardObject("Nine of Diamonds", 9, nineDiamonds));
        UnshuffledDeck.Add(new CardObject("Ten of Diamonds", 10, tenDiamonds));
        UnshuffledDeck.Add(new CardObject("Jack of Diamonds", 10, jackDiamonds));
        UnshuffledDeck.Add(new CardObject("Queen of Diamonds", 10, queenDiamonds));
        UnshuffledDeck.Add(new CardObject("King of Diamonds", 10, kingDiamonds));
        UnshuffledDeck.Add(new CardObject("Ace of Hearts", 1, aceHearts));
        UnshuffledDeck.Add(new CardObject("Two of Hearts", 2, twoHearts));
        UnshuffledDeck.Add(new CardObject("Three of Hearts", 3, threeHearts));
        UnshuffledDeck.Add(new CardObject("Four of Hearts", 4, fourHearts));
        UnshuffledDeck.Add(new CardObject("Five of Hearts", 5, fiveHearts));
        UnshuffledDeck.Add(new CardObject("Six of Hearts", 6, sixHearts));
        UnshuffledDeck.Add(new CardObject("Seven of Hearts", 7, sevenHearts));
        UnshuffledDeck.Add(new CardObject("Eight of Hearts", 8, eightHearts));
        UnshuffledDeck.Add(new CardObject("Nine of Hearts", 9, nineHearts));
        UnshuffledDeck.Add(new CardObject("Ten of Hearts", 10, tenHearts));
        UnshuffledDeck.Add(new CardObject("Jack of Hearts", 10, jackHearts));
        UnshuffledDeck.Add(new CardObject("Queen of Hearts", 10, queenHearts));
        UnshuffledDeck.Add(new CardObject("King of Hearts", 10, kingHearts));
        UnshuffledDeck.Add(new CardObject("Ace of Spades", 1, aceSpades));
        UnshuffledDeck.Add(new CardObject("Two of Spades", 2, twoSpades));
        UnshuffledDeck.Add(new CardObject("Three of Spades", 3, threeSpades));
        UnshuffledDeck.Add(new CardObject("Four of Spades", 4, fourSpades));
        UnshuffledDeck.Add(new CardObject("Five of Spades", 5, fiveSpades));
        UnshuffledDeck.Add(new CardObject("Six of Spades", 6, sixSpades));
        UnshuffledDeck.Add(new CardObject("Seven of Spades", 7, sevenSpades));
        UnshuffledDeck.Add(new CardObject("Eight of Spades", 8, eightSpades));
        UnshuffledDeck.Add(new CardObject("Nine of Spades", 9, nineSpades));
        UnshuffledDeck.Add(new CardObject("Ten of Spades", 10, tenSpades));
        UnshuffledDeck.Add(new CardObject("Jack of Spades", 10, jackSpades));
        UnshuffledDeck.Add(new CardObject("Queen of Spades", 10, queenSpades));
        UnshuffledDeck.Add(new CardObject("King of Spades", 10, kingSpades));
        /*
        UnshuffledDeck.Add(52, new CardObject("Joker", 0, joker));
        UnshuffledDeck.Add(53, new CardObject("Joker", 0, joker));
        */
        return (UnshuffledDeck);
    }

    public Stack<CardObject> ShuffleDeck(List<CardObject> UnshuffledDeck)
    {
        var ShuffledDeck = new Stack<CardObject>();
        System.Random rand = new System.Random();
        for (int i = 0; i < UnshuffledDeck.Count; i++)
        {
            int r = rand.Next(UnshuffledDeck.Count);
            ShuffledDeck.Push(UnshuffledDeck[r]);
        }
        return (ShuffledDeck);
    }

    void Awake()
    {
        if (definitions == null)
        {
            DontDestroyOnLoad(gameObject); //makes instance persist across scenes
            definitions = this;
        }
        else if (definitions != this)
        {
            Destroy(gameObject); //deletes copies of CardsLib which do not need to exist, so right version is used to get info from
        }
    }
}
