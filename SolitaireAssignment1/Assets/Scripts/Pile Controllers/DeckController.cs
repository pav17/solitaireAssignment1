using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour
{

    void OnMouseDown()
    {
        if (GameController.Controller.GameDeck.Count > 0)
        {
            CardObject card = GameController.Controller.GameDeck.Pop();
            GameController.Controller.DiscardPile.Push(card);
            GameController.Controller.Discard.GetComponent<SpriteRenderer>().sprite = GameController.Controller.DiscardPile.Peek().Image;
        }
        else
        {
            GameController.Controller.DeckShuffles = GameController.Controller.DeckShuffles + 1;
            int loopLimit = GameController.Controller.DiscardPile.Count;
            for (int i = 0; i < loopLimit; i++)
            {
                CardObject card = GameController.Controller.DiscardPile.Pop();
                GameController.Controller.GameDeck.Push(card);
            }
            GameController.Controller.DrawCard(GameController.Controller.Discard, GameController.Controller.DiscardPile, GameController.Controller.GameDeck);
        }
    }
}
