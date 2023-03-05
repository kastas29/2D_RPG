using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInventory : MonoBehaviour
{
    [SerializeField] GameObject slot;
    public GameObject slotsContainer;
    [SerializeField] InventoryContent inventoryContent;


    InventorySlot[] inventorySlots;
    void Start()
    {
        Inventory.Instance.onInventoryChanged += updateInventory;
        addSlot(Equipment.Instance.getBackpacksCapacity());
        refreshInventorySlots();
        updateInventory();
    }

    // coloca los items en la UI del inventario
    public void updateInventory()
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (i < inventoryContent.Items.Count)
            {
                inventorySlots[i].addItemIventoryToUI(inventoryContent.Items[i]);
            }
            else
            {
                if (inventorySlots[i] != null)
                {
                    inventorySlots[i].removeItemIventoryFromUI();
                }

            }
        }
    }


    //BACKPACKS
    public void addSlot(int num)
    {
        for (int i = 0; i < num; i++)
        {
            Inventory.Instance.addSlot();
            GameObject newSlot = Instantiate(slot);
            newSlot.transform.SetParent(slotsContainer.transform);
            newSlot.transform.localScale = new Vector3(1, 1, 1);
        }
        refreshInventorySlots();
    }

    public bool removeSlot(int backpackSpace)
    {
        if ((inventoryContent.Items.Count) < (inventoryContent.InventoryMaxCapacity - backpackSpace))
        {
            for (int i = 0; i < backpackSpace; i++)
            {
                print(inventoryContent.InventoryMaxCapacity - 1);
                Destroy(slotsContainer.transform.GetChild(inventoryContent.InventoryMaxCapacity - 1).gameObject);
                Inventory.Instance.removeSlot();
            }
            refreshInventorySlots();
            return true;
        }
        return false;
    }

    public void refreshInventorySlots()
    {
        inventorySlots = slotsContainer.GetComponentsInChildren<InventorySlot>();
    }
}
