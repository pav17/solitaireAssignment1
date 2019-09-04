using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject : MonoBehaviour
{

    public int Value;
    public string Name;
    public Sprite Image;

    public CardObject(string SetName, int SetValue, Sprite SetImageLocation)
    {
        Value = SetValue;
        Name = SetName;
        Image = SetImageLocation;
    }
}
