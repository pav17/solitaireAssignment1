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
        UnshuffledDeck.Add(new CardObject(1, 1, 1,aceClubs));
        UnshuffledDeck.Add(new CardObject(2, 2, 1, twoClubs));
        UnshuffledDeck.Add(new CardObject(3, 3, 1, threeClubs));
        UnshuffledDeck.Add(new CardObject(4, 4, 1, fourClubs));
        UnshuffledDeck.Add(new CardObject(5, 5, 1, fiveClubs));
        UnshuffledDeck.Add(new CardObject(6, 6, 1, sixClubs));
        UnshuffledDeck.Add(new CardObject(7, 7, 1, sevenClubs));
        UnshuffledDeck.Add(new CardObject(8, 8, 1, eightClubs));
        UnshuffledDeck.Add(new CardObject(9, 9, 1, nineClubs));
        UnshuffledDeck.Add(new CardObject(10, 10, 1, tenClubs));
        UnshuffledDeck.Add(new CardObject(10, 11, 1, jackClubs));
        UnshuffledDeck.Add(new CardObject(10, 12, 1, queenClubs));
        UnshuffledDeck.Add(new CardObject(10, 13, 1, kingClubs));
        UnshuffledDeck.Add(new CardObject(1, 1, 2, aceDiamonds));
        UnshuffledDeck.Add(new CardObject(2, 2, 2, twoDiamonds));
        UnshuffledDeck.Add(new CardObject(3, 3, 2, threeDiamonds));
        UnshuffledDeck.Add(new CardObject(4, 4, 2, fourDiamonds));
        UnshuffledDeck.Add(new CardObject(5, 5, 2, fiveDiamonds));
        UnshuffledDeck.Add(new CardObject(6, 6, 2, sixDiamonds));
        UnshuffledDeck.Add(new CardObject(7, 7, 2, sevenDiamonds));
        UnshuffledDeck.Add(new CardObject(8, 8, 2, eightDiamonds));
        UnshuffledDeck.Add(new CardObject(9, 9, 2, nineDiamonds));
        UnshuffledDeck.Add(new CardObject(10, 10, 2, tenDiamonds));
        UnshuffledDeck.Add(new CardObject(10, 11, 2, jackDiamonds));
        UnshuffledDeck.Add(new CardObject(10, 12, 2, queenDiamonds));
        UnshuffledDeck.Add(new CardObject(10, 13, 2, kingDiamonds));
        UnshuffledDeck.Add(new CardObject(1, 1, 3, aceHearts));
        UnshuffledDeck.Add(new CardObject(2, 2, 3, twoHearts));
        UnshuffledDeck.Add(new CardObject(3, 3, 3, threeHearts));
        UnshuffledDeck.Add(new CardObject(4, 4, 3, fourHearts));
        UnshuffledDeck.Add(new CardObject(5, 5, 3, fiveHearts));
        UnshuffledDeck.Add(new CardObject(6, 6, 3, sixHearts));
        UnshuffledDeck.Add(new CardObject(7, 7, 3, sevenHearts));
        UnshuffledDeck.Add(new CardObject(8, 8, 3, eightHearts));
        UnshuffledDeck.Add(new CardObject(9, 9, 3, nineHearts));
        UnshuffledDeck.Add(new CardObject(10, 10, 3, tenHearts));
        UnshuffledDeck.Add(new CardObject(10, 11, 3, jackHearts));
        UnshuffledDeck.Add(new CardObject(10, 12, 3, queenHearts));
        UnshuffledDeck.Add(new CardObject(10, 13, 3, kingHearts));
        UnshuffledDeck.Add(new CardObject(1, 1, 4, aceSpades));
        UnshuffledDeck.Add(new CardObject(2, 2, 4, twoSpades));
        UnshuffledDeck.Add(new CardObject(3, 3, 4, threeSpades));
        UnshuffledDeck.Add(new CardObject(4, 4, 4, fourSpades));
        UnshuffledDeck.Add(new CardObject(5, 5, 4, fiveSpades));
        UnshuffledDeck.Add(new CardObject(6, 6, 4, sixSpades));
        UnshuffledDeck.Add(new CardObject(7, 7, 4, sevenSpades));
        UnshuffledDeck.Add(new CardObject(8, 8, 4, eightSpades));
        UnshuffledDeck.Add(new CardObject(9, 9, 4, nineSpades));
        UnshuffledDeck.Add(new CardObject(10, 10, 4, tenSpades));
        UnshuffledDeck.Add(new CardObject(10, 11, 4, jackSpades));
        UnshuffledDeck.Add(new CardObject(10, 12, 4, queenSpades));
        UnshuffledDeck.Add(new CardObject(10, 13, 4, kingSpades));
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
            UnshuffledDeck.RemoveAt(r);
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
