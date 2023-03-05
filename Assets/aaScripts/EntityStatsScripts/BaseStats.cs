using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BaseStats : ScriptableObject
{

    [SerializeField] int hp;
    [SerializeField] int stamina;
    [SerializeField] float stamina_regenVelocity;
    [SerializeField] int mana;
    [SerializeField] float mana_regenVelocity;
    [SerializeField] int dmg;
    [SerializeField] int speed;
    [SerializeField] int criticalDmg;
    [SerializeField] int criticalPercent;
    [SerializeField] int criticalResistance;
    [SerializeField] int armor;
    [SerializeField] int shield;
    [SerializeField] int damagePercent;
    [SerializeField] int peso;

    [SerializeField] int FireMaestry;
    [SerializeField] int WaterMaestry;
    [SerializeField] int EarthMaestry;
    [SerializeField] int AirMaestry;

    [SerializeField] int xp;
    [SerializeField] int xp_nextLevel;
    [SerializeField] int level;


    public int Hp { get => hp; set => hp = value; }
    public int Stamina { get => stamina; set => stamina = value; }
    public float Stamina_regenVelocity { get => stamina_regenVelocity; set => stamina_regenVelocity = value; }
    public int Mana { get => mana; set => mana = value; }
    public float Mana_regenVelocity { get => mana_regenVelocity; set => mana_regenVelocity = value; }
    public int Dmg { get => dmg; set => dmg = value; }
    public int Speed { get => speed; set => speed = value; }
    public int CriticalDmg { get => criticalDmg; set => criticalDmg = value; }
    public int CriticalPercent { get => criticalPercent; set => criticalPercent = value; }
    public int CriticalResistance { get => criticalResistance; set => criticalResistance = value; }
    public int Armor { get => armor; set => armor = value; }
    public int Shield { get => shield; set => shield = value; }
    public int DamagePercent { get => damagePercent; set => damagePercent = value; }
    public int Peso { get => peso; set => peso = value; }
    public string Name { get => name; set => name = value; }
    public int Xp { get => xp; set => xp = value; }
    public int Level { get => level; set => level = value; }
    public int Xp_nextLevel { get => xp_nextLevel; set => xp_nextLevel = value; }
}
