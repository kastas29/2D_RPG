using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot : MonoBehaviour
{

    public Item item;
    public Image itemIcon;
    public Image defaultImage;

    public void addEquipmentToUI(Item newItem)
    {
        item = newItem;
        itemIcon.sprite = item.sprite;
        itemIcon.enabled = true;
        defaultImage.enabled = false;
    }
    public void removeEquipmentToUI()
    {
        item = null;
        itemIcon.enabled = false;
        defaultImage.enabled = true;
    }

    public void callRemove()
    {
        if (item != null)
        {
            item.remove();
        }

    }
}
