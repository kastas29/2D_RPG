using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameSlot : ScriptableObject
{
    [SerializeField] string slotName;

    public string SlotName { get => slotName; set => slotName = value; }
}
