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



    public Dictionary<int, CardObject> BuildDeck()
    {
        var UnshuffledDeck = new Dictionary<int, CardObject>();
        UnshuffledDeck.Add(0, new CardObject("Ace of Clubs", 1, "/"));
        return (UnshuffledDeck);
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
