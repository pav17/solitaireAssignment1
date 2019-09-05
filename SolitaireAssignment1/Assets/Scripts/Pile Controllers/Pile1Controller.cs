using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile1Controller : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameController.Controller.PlayFromDiscardFlag == false && GameController.Controller.PlayFromPileFlag == false)
        {
            GameController.Controller.PlayFromPileFlag = true;
            GameController.Controller.sourceMoveStack = GameController.Controller.Pile1;
            GameController.Controller.sourceObj = GameController.Controller.Pile1Obj;
            if (GameController.Controller.Pile1.Peek().Number == GameController.Controller.Pile2.Peek().Number || GameController.Controller.Pile1.Peek().Suite == GameController.Controller.Pile2.Peek().Suite)
            {
                GameController.Controller.Pile2Playable = true;
            }
            if (GameController.Controller.Pile1.Peek().Number == GameController.Controller.Pile2.Peek().Number || GameController.Controller.Pile1.Peek().Suite == GameController.Controller.Pile2.Peek().Suite)
            {
                GameController.Controller.Pile2Playable = true;
            }
            if (GameController.Controller.Pile1.Peek().Number == GameController.Controller.Pile3.Peek().Number || GameController.Controller.Pile1.Peek().Suite == GameController.Controller.Pile3.Peek().Suite)
            {
                GameController.Controller.Pile3Playable = true;
            }
        }
        else if (GameController.Controller.PlayFromPileFlag == true)
        {
            GameController.Controller.targetMoveStack = GameController.Controller.Pile1;
            GameController.Controller.targetObj = GameController.Controller.Pile1Obj;
            GameController.Controller.PlayFromPile(GameController.Controller.sourceMoveStack, GameController.Controller.sourceObj, GameController.Controller.targetMoveStack, GameController.Controller.targetObj);
        }
    }
}
