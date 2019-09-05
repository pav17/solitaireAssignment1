using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    List<CardObject> UnshuffledDeck = new List<CardObject>();

    Stack<CardObject> ShuffledDeck = new Stack<CardObject>();
    Stack<CardObject> DiscardPile = new Stack<CardObject>();
    Stack<CardObject> GameDeck = new Stack<CardObject>();
    Stack<CardObject> Pile1 = new Stack<CardObject>();
    Stack<CardObject> Pile2 = new Stack<CardObject>();
    Stack<CardObject> Pile3 = new Stack<CardObject>();
    Stack<CardObject> Pile4 = new Stack<CardObject>();

    public GameObject Deck;
    public GameObject Discard;
    public GameObject Pile1Obj;
    public GameObject Pile2Obj;
    public GameObject Pile3Obj;
    public GameObject Pile4Obj;

    // Start is called before the first frame update
    void Start()
    {
        UnshuffledDeck = CardsLib.definitions.BuildDeck();
        ShuffledDeck = CardsLib.definitions.ShuffleDeck(UnshuffledDeck);
        GameDeck = ShuffledDeck;
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGame()
    {
        SetupStack(Pile1Obj, Pile1, GameDeck);
        SetupStack(Pile2Obj, Pile2, GameDeck);
        SetupStack(Pile3Obj, Pile3, GameDeck);
        SetupStack(Pile4Obj, Pile4, GameDeck);
        DrawCard(Discard, DiscardPile, GameDeck);
    }

    void SetupStack(GameObject PileObj, Stack<CardObject> PileStack, Stack<CardObject> DeckStack)
    {
        for(int i = 0; i < 4; i++)
        {
            CardObject card = DeckStack.Pop();
            PileStack.Push(card);
        }
        PileObj.GetComponent<SpriteRenderer>().sprite = PileStack.Peek().Image;
    }

    void DrawCard(GameObject DiscardObj, Stack<CardObject> DiscardStack, Stack<CardObject> DeckStack)
    {
        CardObject card = DeckStack.Pop();
        DiscardStack.Push(card);
        DiscardObj.GetComponent<SpriteRenderer>().sprite = DiscardStack.Peek().Image;
    }
}
