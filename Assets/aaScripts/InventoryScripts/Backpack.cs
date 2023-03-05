using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Backpack : Item
{
    public int space;
    public EquipmentType equipmentType;

    public override void use()
    {
        Equipment.Instance.addBackpack(this);
    }

    public override void remove()
    {
        Equipment.Instance.removeBackpack(this);
    }
}