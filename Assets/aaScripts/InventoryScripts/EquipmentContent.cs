using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EquipmentContent : ScriptableObject
{
    [SerializeField] Equip[] characterEquipment = new Equip[8];
    [SerializeField] Backpack[] backpacks = new Backpack[4];

    public Equip[] CharacterEquipment { get => characterEquipment; set => characterEquipment = value; }
    public Backpack[] Backpacks { get => backpacks; set => backpacks = value; }
}
