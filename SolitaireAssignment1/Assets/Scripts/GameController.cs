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
    public Text ShuffleCount;

    public Text OutcomeText;
    public Text FinalScoreText;
    public Button NewGameButton;

    public bool PlayFromDiscardFlag = false;
    public bool PlayFromPileFlag = false;
    public bool Pile1Playable = false;
    public bool Pile2Playable = false;
    public bool Pile3Playable = false;
    public bool Pile4Playable = false;

    public GameObject SelectedD;
    public GameObject Selected1;
    public GameObject Selected2;
    public GameObject Selected3;
    public GameObject Selected4;

    public GameObject Legal1;
    public GameObject Legal2;
    public GameObject Legal3;
    public GameObject Legal4;

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

    public int DeckShuffles = 0;
    public bool EndFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        OutcomeText.gameObject.SetActive(false);
        FinalScoreText.gameObject.SetActive(false);
        NewGameButton.gameObject.SetActive(false);
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
            SelectedD.SetActive(true);
            if (Pile1.Peek().Number == DiscardPile.Peek().Number || Pile1.Peek().Suite == DiscardPile.Peek().Suite || Pile1.Count == 1)
            {
                Pile1Playable = true;
            }
            if (Pile2.Peek().Number == DiscardPile.Peek().Number || Pile2.Peek().Suite == DiscardPile.Peek().Suite || Pile2.Count == 1)
            {
                Pile2Playable = true;
            }
            if (Pile3.Peek().Number == DiscardPile.Peek().Number || Pile3.Peek().Suite == DiscardPile.Peek().Suite || Pile3.Count == 1)
            {
                Pile3Playable = true;
            }
            if (Pile4.Peek().Number == DiscardPile.Peek().Number || Pile4.Peek().Suite == DiscardPile.Peek().Suite || Pile4.Count == 1)
            {
                Pile4Playable = true;
            }
        }
        else if (PlayFromPileFlag)
        {

        }
        else
        {
            Selected1.SetActive(false);
            Selected2.SetActive(false);
            Selected3.SetActive(false);
            Selected4.SetActive(false);
            SelectedD.SetActive(false);
            Pile1Playable = false;
            Pile2Playable = false;
            Pile3Playable = false;
            Pile4Playable = false;
        }

        if(Pile1Playable)
        {
            Legal1.SetActive(true);
        }
        else
        {
            Legal1.SetActive(false);
        }
        if (Pile2Playable)
        {
            Legal2.SetActive(true);
        }
        else
        {
            Legal2.SetActive(false);
        }
        if (Pile3Playable)
        {
            Legal3.SetActive(true);
        }
        else
        {
            Legal3.SetActive(false);
        }
        if (Pile4Playable)
        {
            Legal4.SetActive(true);
        }
        else
        {
            Legal4.SetActive(false);
        }

        Pile1ScoreValue = CalculateScore(Pile1, Pile1ScoreValue);
        Pile2ScoreValue = CalculateScore(Pile2, Pile2ScoreValue);
        Pile3ScoreValue = CalculateScore(Pile3, Pile3ScoreValue);
        Pile4ScoreValue = CalculateScore(Pile4, Pile4ScoreValue);
        DisplayScores();
        /*
        Debug.Log("Discard Flag: " + PlayFromDiscardFlag.ToString());
        Debug.Log("Pile Flag: " + PlayFromPileFlag.ToString());
        Debug.Log("Pile 1 Playable: " + Pile1Playable.ToString());
        Debug.Log("Pile 2 Playable: " + Pile2Playable.ToString());
        Debug.Log("Pile 3 Playable: " + Pile3Playable.ToString());
        Debug.Log("Pile 4 Playable: " + Pile4Playable.ToString());
        */
        if(DeckShuffles > 1)
        {
            EndFlag = true;
        }
        CheckEndCondition();
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
        PileStack.Push(new CardObject(0, 0, 0, placeholderCardImage));
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
        if (DeckShuffles == 0)
        {
            ShuffleCount.text = "Reshuffles Left: 1";
        }
        else
        {
            ShuffleCount.text = "Reshuffles Left: 0";
        }
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

    int CalculateScore(Stack<CardObject> PileStack, int Score)
    {
        CardObject[] PileArray = PileStack.ToArray();
        int ArrayLength = PileArray.Length;
        int PileScore = 0;
        for(int i = 0; i < ArrayLength; i++)
        {
            //Debug.Log(PileArray[i].Value);
            PileScore = PileScore + PileArray[i].Value;
        }
        Score = PileScore;
        return(Score);
    }

    int CalculateFinalScore()
    {
        int ComboScore1 = Mathf.Abs(Pile1ScoreValue - Pile2ScoreValue);
        int ComboScore2 = Mathf.Abs(Pile3ScoreValue - Pile4ScoreValue);
        int finalScore = Mathf.Abs(ComboScore1 - ComboScore2) + GameDeck.Count;
        return (finalScore);
    }

    void DisplayScores()
    {
        //Debug.Log("Pile 1 Score: " + Pile1ScoreValue.ToString());
        Pile1Score.text = "Pile Score: " + Pile1ScoreValue.ToString();
        //Debug.Log("Pile 2 Score: " + Pile2ScoreValue.ToString());
        Pile2Score.text = "Pile Score: " + Pile2ScoreValue.ToString();
        //Debug.Log("Pile 3 Score: " + Pile3ScoreValue.ToString());
        Pile3Score.text = "Pile Score: " + Pile3ScoreValue.ToString();
        //Debug.Log("Pile 4 Score: " + Pile4ScoreValue.ToString());
        Pile4Score.text = "Pile Score: " + Pile4ScoreValue.ToString();
    }

    void CheckEndCondition ()
    {
        if(EndFlag == true)
        {
            OutcomeText.gameObject.SetActive(true);
            FinalScoreText.gameObject.SetActive(true);
            NewGameButton.gameObject.SetActive(true);
            OutcomeText.text = "Game Over";
            FinalScoreText.text = "Final Score: " + CalculateFinalScore();
        }
    }

    void Awake()
    {
        if (Controller == null)
        {
            Controller = this;
        }
        else if (Controller != this)
        {
            Destroy(gameObject); //deletes copies of CardsLib which do not need to exist, so right version is used to get info from
        }
    }
}
