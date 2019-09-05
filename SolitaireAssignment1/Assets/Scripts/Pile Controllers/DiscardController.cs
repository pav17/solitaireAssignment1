using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardController : MonoBehaviour
{

    private void OnMouseDown()
    {
        if((GameController.Controller.DiscardPile.Count - 1) > 0)
        {
            GameController.Controller.PlayFromDiscardFlag = true;
        }
    }
}
