using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardController : MonoBehaviour
{

    private void OnMouseDown()
    {
        GameController.Controller.PlayFromDiscardFlag = true;
    }
}
