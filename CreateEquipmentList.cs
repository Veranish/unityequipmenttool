using UnityEngine;
using System.Collections;
using UnityEditor;
//Created by Weston Jones - December 2017 for the purposes of the game "Necromantic"
public class CreateEquipmentList
{
    [MenuItem("Assets/Create/Equipment Item List")]
    public static EquipmentList Create()
    {
        EquipmentList asset = ScriptableObject.CreateInstance<EquipmentList>();

        AssetDatabase.CreateAsset(asset, "Assets/EquipmentList.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    
}