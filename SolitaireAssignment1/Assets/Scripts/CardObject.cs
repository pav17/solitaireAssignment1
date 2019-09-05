using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject
{

    public int Value;
    public int Number;//1-10 = 1-10, 11 = Jack, 12 = Queen, 13 = King
    public int Suite; //1 = Clubs, 2 = Diamonds, 3 = Hearts, 4 = Spades
    public Sprite Image;

    public CardObject(int SetValue, int SetNumber, int SetSuite, Sprite SetImageLocation)
    {
        Value = SetValue;
        Number = SetNumber;
        Suite = SetSuite;
        Image = SetImageLocation;
    }
}
