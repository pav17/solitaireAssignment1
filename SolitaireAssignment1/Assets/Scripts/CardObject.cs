using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject : MonoBehaviour
{

    public int Value;
    public string Name;
    public string Image;

    public CardObject(string SetName, int SetValue, string SetImageLocation)
    {
        Value = SetValue;
        Name = SetName;
        Image = SetImageLocation;
        
    }
}
