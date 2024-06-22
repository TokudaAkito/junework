using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ItamData", menuName = "CreateItemData")]
public class ItemData : ScriptableObject
{
    [SerializeField] private List<Item> _itemLists;
    public List<Item> GetItemLists()
    {
        return _itemLists;
    }
}
