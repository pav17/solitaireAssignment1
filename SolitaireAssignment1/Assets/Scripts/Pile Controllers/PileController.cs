using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileController : MonoBehaviour
{
    private void OnMouseUp()
    {
        if(GameController.Controller.PlayFromDiscardFlag)
        {
            if(GameController.Controller.Pile1Playable && gameObject.name == "Pile1")
            {
                //highlight position
                CardObject card = GameController.Controller.DiscardPile.Pop();
                GameController.Controller.Pile1.Push(card);
                GameController.Controller.Pile1Obj.GetComponent<SpriteRenderer>().sprite = GameController.Controller.Pile1.Peek().Image;
                GameController.Controller.Discard.GetComponent<SpriteRenderer>().sprite = GameController.Controller.DiscardPile.Peek().Image;
                GameController.Controller.PlayFromDiscardFlag = false;
            }
            if (GameController.Controller.Pile2Playable && gameObject.name == "Pile2")
            {
                //highlight position
                CardObject card = GameController.Controller.DiscardPile.Pop();
                GameController.Controller.Pile2.Push(card);
                GameController.Controller.Pile2Obj.GetComponent<SpriteRenderer>().sprite = GameController.Controller.Pile2.Peek().Image;
                GameController.Controller.Discard.GetComponent<SpriteRenderer>().sprite = GameController.Controller.DiscardPile.Peek().Image;
                GameController.Controller.PlayFromDiscardFlag = false;
            }
            if (GameController.Controller.Pile3Playable && gameObject.name == "Pile3")
            {
                //highlight position
                CardObject card = GameController.Controller.DiscardPile.Pop();
                GameController.Controller.Pile3.Push(card);
                GameController.Controller.Pile3Obj.GetComponent<SpriteRenderer>().sprite = GameController.Controller.Pile3.Peek().Image;
                GameController.Controller.Discard.GetComponent<SpriteRenderer>().sprite = GameController.Controller.DiscardPile.Peek().Image;
                GameController.Controller.PlayFromDiscardFlag = false;
            }
            if (GameController.Controller.Pile4Playable && gameObject.name == "Pile4")
            {
                //highlight position
                CardObject card = GameController.Controller.DiscardPile.Pop();
                GameController.Controller.Pile4.Push(card);
                GameController.Controller.Pile4Obj.GetComponent<SpriteRenderer>().sprite = GameController.Controller.Pile4.Peek().Image;
                GameController.Controller.Discard.GetComponent<SpriteRenderer>().sprite = GameController.Controller.DiscardPile.Peek().Image;
                GameController.Controller.PlayFromDiscardFlag = false;
            }
        }
    }
}
