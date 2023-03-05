using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        inventoryContent.InventoryMaxCapacity = 105;


    }

    [SerializeField] InventoryContent inventoryContent;


    public delegate void OnInventoryChanged();
    public OnInventoryChanged onInventoryChanged;

    public bool addItem(Item item)
    {
        if (inventoryContent.Items.Count >= inventoryContent.InventoryMaxCapacity)
        {
            return false;
        }
        inventoryContent.Items.Add(item);
        onInventoryChanged?.Invoke();
        return true;
    }

    public void removeItem(Item item)
    {
        inventoryContent.Items.Remove(item);
        onInventoryChanged?.Invoke();
    }

    // BACKPACKS
    public void addSlot()
    {
        inventoryContent.InventoryMaxCapacity++;
    }
    public void removeSlot()
    {
        inventoryContent.InventoryMaxCapacity--;
    }
}
