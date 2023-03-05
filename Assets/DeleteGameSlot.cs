using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteGameSlot : MonoBehaviour
{
    [SerializeField] CharacterStats stats;
    [SerializeField] OdinSave defaultData;
    [SerializeField] SaveGameOdin odin;

    public void deleteSlotData(string slotName)
    {
        odin.defaultGame(slotName, defaultData, stats);
    }
}
