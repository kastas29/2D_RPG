using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    [SerializeField] public Sprite sprite;
    [SerializeField] public new string name;
    [SerializeField] public Rarity rarity;
    [SerializeField] public int buyPrice;

    public virtual void use() { }

    public virtual void remove() { }

}

public enum Element
{
    None, Fire, Water, Earth, Air

}

public enum Rarity
{
    Commun, Uncommun, Rare, Epic, Legendary, Mitic
}

public enum RarityColors
{
    Grey, Green, Blue, Purple, Yellow, Red
}

public enum EquipmentType
{
    Helmet, Necklace, Chest, Ring, Pant, Shield, Boot, Weapon, Backpack
}