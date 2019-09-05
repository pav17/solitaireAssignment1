using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile2Controller : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameController.Controller.PlayFromDiscardFlag == false && GameController.Controller.PlayFromPileFlag == false && GameController.Controller.Pile2.Count > 1)
        {
            GameController.Controller.Selected2.SetActive(true);
            GameController.Controller.PlayFromPileFlag = true;
            GameController.Controller.sourceMoveStack = GameController.Controller.Pile2;
            GameController.Controller.sourceObj = GameController.Controller.Pile2Obj;
            if (GameController.Controller.Pile2.Peek().Number == GameController.Controller.Pile1.Peek().Number || GameController.Controller.Pile2.Peek().Suite == GameController.Controller.Pile1.Peek().Suite
                || GameController.Controller.Pile1.Count == 1)
            {
                GameController.Controller.Pile1Playable = true;
            }
            if (GameController.Controller.Pile2.Peek().Number == GameController.Controller.Pile3.Peek().Number || GameController.Controller.Pile2.Peek().Suite == GameController.Controller.Pile3.Peek().Suite
                || GameController.Controller.Pile3.Count == 1)
            {
                GameController.Controller.Pile3Playable = true;
            }
            if (GameController.Controller.Pile2.Peek().Number == GameController.Controller.Pile4.Peek().Number || GameController.Controller.Pile2.Peek().Suite == GameController.Controller.Pile4.Peek().Suite
                || GameController.Controller.Pile4.Count == 1)
            {
                GameController.Controller.Pile4Playable = true;
            }
        }
        else if (GameController.Controller.PlayFromPileFlag == true && GameController.Controller.Pile2Playable == true)
        {
            GameController.Controller.targetMoveStack = GameController.Controller.Pile2;
            GameController.Controller.targetObj = GameController.Controller.Pile2Obj;
            GameController.Controller.PlayFromPile(GameController.Controller.sourceMoveStack, GameController.Controller.sourceObj, GameController.Controller.targetMoveStack, GameController.Controller.targetObj);
        }
        else if (GameController.Controller.Pile2.Count == 1)
        {
            GameController.Controller.targetMoveStack = GameController.Controller.Pile4;
            GameController.Controller.targetObj = GameController.Controller.Pile4Obj;
            GameController.Controller.PlayFromPile(GameController.Controller.sourceMoveStack, GameController.Controller.sourceObj, GameController.Controller.targetMoveStack, GameController.Controller.targetObj);
        }
    }
}
