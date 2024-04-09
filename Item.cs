using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Created by Weston Jones - December 2017 for the purposes of the game "Necromantic"
//Last updated: December 2018

[System.Serializable]

public class Item : ScriptableObject
{

    //protected vs private, protected can be accessed by children.
    //Children of Item: Equipment
    public string myName;
    public int level; //The equipment's level, to be used to determine equipable level and value.
    public int moneyValue; //Sell/buy value base. May use an algorhtyhm to determine. 
    public double weight;
    //protected Ability ability;

    public Item()
    {
        myName = "null";
        level = 0;
        moneyValue = 0;
        weight = 0;
    }

    public Item(string nam, int lvl, int val, double wei)
    {
        myName = nam;
        level = lvl;
        moneyValue = val;
        weight = wei;
    }

}
