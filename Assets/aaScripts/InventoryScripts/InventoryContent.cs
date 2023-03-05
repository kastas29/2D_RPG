using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InventoryContent : ScriptableObject
{
    [SerializeField] int inventoryMaxCapacity;
    [SerializeField] List<Item> items = new List<Item>();

    public int InventoryMaxCapacity { get => inventoryMaxCapacity; set => inventoryMaxCapacity = value; }
    public List<Item> Items { get => items; set => items = value; }
}


