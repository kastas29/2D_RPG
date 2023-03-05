using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Equip : Item
{
    [SerializeField] public int level;
    [SerializeField] public int Peso;
    [SerializeField] public EquipmentType equipType;

    [SerializeField] public int hp;
    [SerializeField] public int stamina;
    [SerializeField] public int mana;
    [SerializeField] public int dmg;
    [SerializeField] public int speed;
    [SerializeField] public int criticalDmg;
    [SerializeField] public int criticalPercent;
    [SerializeField] public int criticalResistance;
    [SerializeField] public int armor;
    [SerializeField] public int shield;
    [SerializeField] public int Mind;
    [SerializeField] public int Dexterity;

    public override void use()
    {
        Equipment.Instance.addEquip(this);
    }

    public override void remove()
    {
        Equipment.Instance.desEquip(this);
    }

}
