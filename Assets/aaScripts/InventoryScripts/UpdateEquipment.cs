using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateEquipment : MonoBehaviour
{
    [SerializeField] GameObject equipmentSlotsContainer;
    [SerializeField] GameObject backpackSlotsContainer;
    [SerializeField] EquipmentContent equipmentContent;

    EquipmentSlot[] equipmentSlots;
    EquipmentSlot[] backpackSlots;
    void Start()
    {
        Equipment.Instance.onEquipmentChanged += updateEquipment;
        equipmentSlots = equipmentSlotsContainer.GetComponentsInChildren<EquipmentSlot>();
        backpackSlots = backpackSlotsContainer.GetComponentsInChildren<EquipmentSlot>();
        updateEquipment();
    }

    // coloca el equipamiento en el UI de equipamiento
    public void updateEquipment()
    {
        
        for (int i = 0; i < equipmentSlots.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                equipmentSlots[i].addEquipmentToUI(equipmentContent.CharacterEquipment[i]);
            }
            else
            {
                equipmentSlots[i].removeEquipmentToUI();
            }
        }
        for (int i = 0; i < backpackSlots.Length; i++)
        {
            if (equipmentContent.Backpacks[i] != null)
            {
                backpackSlots[i].addEquipmentToUI(equipmentContent.Backpacks[i]);
            }
            else
            {
                backpackSlots[i].removeEquipmentToUI();
            }
        }
    }
        
}
