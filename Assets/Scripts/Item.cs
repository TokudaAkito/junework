using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using JetBrains.Annotations;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]
public class Item : ScriptableObject
{
    [SerializeField] private string _itemName;  //�A�C�e����
    [SerializeField] private Sprite _icon;  //�A�C�e���A�C�R��

    public string GetItemName()
    {
        return _itemName;
    }

    public Sprite GetIcon()
    {
        return _icon;
    }

}
