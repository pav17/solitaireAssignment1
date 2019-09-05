using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController Controller;

    List<CardObject> UnshuffledDeck = new List<CardObject>();

    Stack<CardObject> ShuffledDeck = new Stack<CardObject>();
    public Stack<CardObject> DiscardPile = new Stack<CardObject>();
    public Stack<CardObject> GameDeck = new Stack<CardObject>();
    public Stack<CardObject> Pile1 = new Stack<CardObject>();
    public Stack<CardObject> Pile2 = new Stack<CardObject>();
    public Stack<CardObject> Pile3 = new Stack<CardObject>();
    public Stack<CardObject> Pile4 = new Stack<CardObject>();

    public GameObject Deck;
    public GameObject Discard;
    public GameObject Pile1Obj;
    public GameObject Pile2Obj;
    public GameObject Pile3Obj;
    public GameObject Pile4Obj;

    public Text DeckCount;
    public Text DiscardCount;

    public bool PlayFromDiscardFlag = false;
    public bool PlayFromPileFlag = false;
    public bool Pile1Playable = false;
    public bool Pile2Playable = false;
    public bool Pile3Playable = false;
    public bool Pile4Playable = false;

    public Sprite placeholderCardImage;
    public CardObject PlaceholderCard;

    public Stack<CardObject> sourceMoveStack;
    public Stack<CardObject> targetMoveStack;
    public GameObject sourceObj;
    public GameObject targetObj;

    int Pile1ScoreValue;
    int Pile2ScoreValue;
    int Pile3ScoreValue;
    int Pile4ScoreValue;

    public Text Pile1Score;
    public Text Pile2Score;
    public Text Pile3Score;
    public Text Pile4Score;

    // Start is called before the first frame update
    void Start()
    {
        PlaceholderCard = new CardObject(0, 0, 0, placeholderCardImage);
        UnshuffledDeck = CardsLib.definitions.BuildDeck();
        ShuffledDeck = CardsLib.definitions.ShuffleDeck(UnshuffledDeck);
        GameDeck = ShuffledDeck;
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        updateUIelements();

        if (PlayFromDiscardFlag)
        {
            if (Pile1.Peek().Number == DiscardPile.Peek().Number || Pile1.Peek().Suite == DiscardPile.Peek().Suite)
            {
                Pile1Playable = true;
            }
            if (Pile2.Peek().Number == DiscardPile.Peek().Number || Pile2.Peek().Suite == DiscardPile.Peek().Suite)
            {
                Pile2Playable = true;
            }
            if (Pile3.Peek().Number == DiscardPile.Peek().Number || Pile3.Peek().Suite == DiscardPile.Peek().Suite)
            {
                Pile3Playable = true;
            }
            if (Pile4.Peek().Number == DiscardPile.Peek().Number || Pile4.Peek().Suite == DiscardPile.Peek().Suite)
            {
                Pile4Playable = true;
            }
        }
        else
        {
            Pile1Playable = false;
            Pile2Playable = false;
            Pile3Playable = false;
            Pile4Playable = false;
        }

        CalculateScore(Pile1, Pile1Score, Pile1ScoreValue);
        CalculateScore(Pile2, Pile2Score, Pile2ScoreValue);
        CalculateScore(Pile3, Pile3Score, Pile3ScoreValue);
        CalculateScore(Pile4, Pile4Score, Pile4ScoreValue);
        DisplayScores();
    }
    

    void StartGame()
    {
        SetupStack(Pile1Obj, Pile1, GameDeck);
        SetupStack(Pile2Obj, Pile2, GameDeck);
        SetupStack(Pile3Obj, Pile3, GameDeck);
        SetupStack(Pile4Obj, Pile4, GameDeck);
        CardObject placeholder = PlaceholderCard;
        DiscardPile.Push(placeholder);
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

    public void DrawCard(GameObject DiscardObj, Stack<CardObject> DiscardStack, Stack<CardObject> DeckStack)
    {
        CardObject card = DeckStack.Pop();
        DiscardStack.Push(card);
        DiscardObj.GetComponent<SpriteRenderer>().sprite = DiscardStack.Peek().Image;
    }

    void updateUIelements()
    {
        DeckCount.text = "Cards in Deck: " + GameDeck.Count.ToString();
        DiscardCount.text = "Cards in Discard: " + (DiscardPile.Count - 1).ToString();
    }

    public void PlayFromPile(Stack<CardObject> PileStack, GameObject PileObj, Stack<CardObject> TargetPileStack, GameObject TargetPileObj)
    {
        CardObject card = PileStack.Pop();
        TargetPileStack.Push(card);
        PileObj.GetComponent<SpriteRenderer>().sprite = PileStack.Peek().Image;
        TargetPileObj.GetComponent<SpriteRenderer>().sprite = TargetPileStack.Peek().Image;
        PlayFromPileFlag = false;
        Pile1Playable = false;
        Pile2Playable = false;
        Pile3Playable = false;
        Pile4Playable = false;
    }

    void CalculateScore(Stack<CardObject> PileStack, Text Display, int Score)
    {
        CardObject[] PileArray = PileStack.ToArray();
        int ArrayLength = PileArray.Length;
        int PileScore = 0;
        for(int i = 0; i < ArrayLength; i++)
        {
            PileScore = PileScore + PileArray[i].Value;
        }
        Score = PileScore;
    }

    void DisplayScores()
    {
        Pile1Score.text = "Pile Score: " + Pile1ScoreValue.ToString();
        Pile2Score.text = "Pile Score: " + Pile2ScoreValue.ToString();
        Pile3Score.text = "Pile Score: " + Pile3ScoreValue.ToString();
        Pile4Score.text = "Pile Score: " + Pile4ScoreValue.ToString();
    }

    void Awake()
    {
        if (Controller == null)
        {
            DontDestroyOnLoad(gameObject); //makes instance persist across scenes
            Controller = this;
        }
        else if (Controller != this)
        {
            Destroy(gameObject); //deletes copies of CardsLib which do not need to exist, so right version is used to get info from
        }
    }
}
