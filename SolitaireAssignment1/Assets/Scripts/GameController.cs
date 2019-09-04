using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    List<CardObject> UnshuffledDeck = new List<CardObject>();
    Stack<CardObject> ShuffledDeck = new Stack<CardObject>();
    // Start is called before the first frame update
    void Start()
    {
        UnshuffledDeck = CardsLib.definitions.BuildDeck();
        ShuffledDeck = CardsLib.definitions.ShuffleDeck(UnshuffledDeck);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
