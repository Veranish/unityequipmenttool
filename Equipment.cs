using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Created by Weston Jones - December 2017 for the purposes of the game "Necromantic"
//Last updated: December 2018
//System.Serializable means the data is written to the hard drive.
[System.Serializable]

public enum SlotType
{
    head, neck, leftEar, rightEar, rightRing, leftRing, shoulders, chest,
    back, arms, hands, legs, feet, blood, heart, skin, primary, secondary, twoHanded, none = -1
};


public enum EquipReq
{
    strReq, dexReq, chaReq, conReq, wisReq, intReq, staReq, none = -1
};//not utilized?

public class StatNameAttributes : PropertyAttribute
{
    public string[] names;
    public StatNameAttributes(string[] names) { this.names = names; }
}


[CreateAssetMenu()]//neccessary to display under the assets/create menu in editor.
public class Equipment : Item
{
    //No monobehaviour because it does not need to inherit the base unity class, it does not need to use start () and update() functions.


    //TODO: Implement dictionary and list<string> to use for stat requirements and modifiers.
    [StatNameAttributes(new string[] { "Strength", "Dexterity", "Charisma", "Constitution",
    "Wisdom", "Intelligence", "Stamina"})]
    public List<int> _statRequirements = new List<int> { 0, 0, 0, 0, 0, 0, 0 };

    [StatNameAttributes(new string[] { "Strength", "Dexterity", "Charisma", "Constitution",
    "Wisdom", "Intelligence", "Stamina"})]
    public List<int> _statIncreases = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
      
    public int ac;
    public SlotType equipSlot = SlotType.none;
    public int hpCapGain;
    public int mpCapGain;
    //For scriptable Objects, overloaded constructors are NOT looked at. 
    public Equipment()
    {
        myName = "not set";
        equipSlot = SlotType.none;
        ac = 0;
        level = 0;
        moneyValue = 0;
        hpCapGain = 0;
        mpCapGain = 0;
        weight = 0;
    }

    public void Initialize(string initName, int initLVL, int initValue, List<int> _initReq,
        List<int> _initIncr, int initAC, SlotType initSlot, int initHP, int initMP, double wei)
    {
        myName = initName;
        level = initLVL;
        moneyValue = initValue;
        _statRequirements = _initReq;
        _statIncreases = _initIncr;
        ac = initAC;
        equipSlot = initSlot;
        hpCapGain = initHP;
        mpCapGain = initMP;
        weight = wei;
    }
       

}


//Creating equipment with weapon-exclusive attributes.
public class Weapon : Equipment
 {
    public int damage; //damage, for use on weapons only.
    bool twoHanded;

    public Weapon ()
    {     
        damage = 0;
        twoHanded = false;
        myName = "not set";
        equipSlot = SlotType.none;
        ac = 0;
        level = 0;
        moneyValue = 0;
        hpCapGain = 0;
        mpCapGain = 0;
        weight = 0;
    }

    public void Initialize(string initName, int initLVL, int initValue, int initDmg, bool initTwoH, List<int> _initReq, List<int> _initIncr, int initAC, SlotType initSlot, int initHP, int initMP, double wei)
    {
        myName = initName;
        level = initLVL;
        moneyValue = initValue;
        damage = initDmg;
        twoHanded = initTwoH;
        _statRequirements = _initReq;
        _statIncreases = _initIncr;
        ac = initAC;
        equipSlot = initSlot;
        hpCapGain = initHP;
        mpCapGain = initMP;
        weight = wei;
    }

}

   

    


