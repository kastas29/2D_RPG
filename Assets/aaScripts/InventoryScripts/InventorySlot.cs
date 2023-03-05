using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Item item;
    public Image itemIcon;

    public void addItemIventoryToUI(Item newItem)
    {
        item = newItem;
        itemIcon.sprite = item.sprite;
        itemIcon.enabled = true;

    }
    public void removeItemIventoryFromUI()
    {
        itemIcon.enabled = false;
        itemIcon.sprite = null;
        item = null;
    }

    public void UseItem()
    {
        if (item != null)
        {
            item.use();
        }
    }

    public void ShowDefaultItem()
    {
        if (this.itemIcon != null)
        {
            this.transform.GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            this.transform.GetChild(2).gameObject.SetActive(true);
        }

    }

}
