using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyStats : ScriptableObject
{
    [SerializeField] Sprite sprite;
    [SerializeField] new string name;

    [SerializeField] int level;
    [SerializeField] int hp;

    [SerializeField] int dmg;
    [SerializeField] int criticalDmg;
    [SerializeField] int speed;
    [SerializeField] int armor;

    [SerializeField] Element element;
    [SerializeField] int criticalPercent;
    [SerializeField] int criticalResistance;

    public int Hp
    {
        set { hp = value; }
        get { return hp; }
    }
    public Sprite Sprite
    {
        set { sprite = value; }
        get { return sprite; }
    }
    public string Name
    {
        set { name = value; }
        get { return name; }
    }
    public int Level
    {
        set { level = value; }
        get { return level; }
    }
    public int Dmg
    {
        set { dmg = value; }
        get { return dmg; }
    }
    public int CriticalDmg
    {
        set { criticalDmg = value; }
        get { return criticalDmg; }
    }
    public int Speed
    {
        set { speed = value; }
        get { return speed; }
    }
    public int Armor
    {
        set { armor = value; }
        get { return armor; }
    }
    public Element Element
    {
        set { element = value; }
        get { return element; }
    }
    public int CriticalPercent
    {
        set { criticalPercent = value; }
        get { return criticalPercent; }
    }
    public int CriticalResistance
    {
        set { criticalResistance = value; }
        get { return criticalResistance; }
    }

}


