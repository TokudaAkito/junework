using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]
public class Item : ScriptableObject
{
    [SerializeField] private string _itemName;  //アイテム名
    [SerializeField] private Sprite _icon;  //アイテムアイコン

    public string GetItemName()
    {
        return _itemName;
    }

    public Sprite GetIcon()
    {
        return _icon;
    }

}
