using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterStats : ScriptableObject
{
    [SerializeField] Sprite sprite;
    [SerializeField] new string name;

    [SerializeField] int hp;// Vida del personaje
    [SerializeField] int hp_max;
    [SerializeField] int stamina;// Sirve para correr
    [SerializeField] int stamina_max;
    [SerializeField] float stamina_regenVelocity;
    [SerializeField] int mana;//Sirve para usar hechizos
    [SerializeField] int mana_max;
    [SerializeField] float mana_regenVelocity;
    [SerializeField] int dmg;// daño del personaje.
    [SerializeField] int speed;// Aumenta la velocidad de nuestro personaje. Esta estadistica se obtiene de equipables y consumibles temporales.
    [SerializeField] int criticalDmg;// Daño que se suma al dmg cuando se acesta un ataque critico
    [SerializeField] int criticalPercent;// Porcentaje de acesatar ataques critics
    [SerializeField] int criticalResistance;//reduce el daño recibido de ataques criticos
    [SerializeField] int armor;//reduce el daño general recibido funciona como el DamagePercent
    [SerializeField] int shield;// Si el personaje fuera a recibir daño a la vida, se consume el daño como escudo y si el escudo baja a 0 se inflinge a la vida.
    [SerializeField] int shield_max;
    [SerializeField] int damagePercent;// aumenta el daño final porcentualmente. Por ejemplo si el calculo de daño final es 100 y tines 20 de esta estadistica el daño final aumentara un 20% siendo 120 el daño causado
    [SerializeField] int peso;// define si te puedes equipar un item o no, si se llena el peso no podras equipar otro item y tendras que subir la estadistica a los dark souls
    [SerializeField] int peso_max;


    // Elementos: funcionan igual que el dmg y el CriticalDmg. Si un arma tiene una runa del elemento fuego el FireMaestry se sumata al dmg
    [SerializeField] int FireMaestry;
    [SerializeField] int WaterMaestry;
    [SerializeField] int EarthMaestry;
    [SerializeField] int AirMaestry;

    //xp y nivel. La xp se puede conseguir a travez de misiones o matar enemigos.
    [SerializeField] int xp;
    [SerializeField] int xp_nextLevel;
    [SerializeField] int level;



    public enum role
    {
        WIZARD,
        ASSASSIN,
        WARRIOR,
        ARCHER
    }

    public int Hp { get => hp; set => hp = value; }
    public int Hp_max { get => hp_max; set => hp_max = value; }
    public int Stamina { get => stamina; set => stamina = value; }
    public int Stamina_max { get => stamina_max; set => stamina_max = value; }
    public float Stamina_regenVelocity { get => stamina_regenVelocity; set => stamina_regenVelocity = value; }
    public int Mana { get => mana; set => mana = value; }
    public int Mana_max { get => mana_max; set => mana_max = value; }
    public float Mana_regenVelocity { get => mana_regenVelocity; set => mana_regenVelocity = value; }
    public int Dmg { get => dmg; set => dmg = value; }
    public int Speed { get => speed; set => speed = value; }
    public int CriticalDmg { get => criticalDmg; set => criticalDmg = value; }
    public int CriticalPercent { get => criticalPercent; set => criticalPercent = value; }
    public int CriticalResistance { get => criticalResistance; set => criticalResistance = value; }
    public int Armor { get => armor; set => armor = value; }
    public int Shield { get => shield; set => shield = value; }
    public int Shield_max { get => shield_max; set => shield_max = value; }
    public int DamagePercent { get => damagePercent; set => damagePercent = value; }
    public int Peso { get => peso; set => peso = value; }
    public int Peso_max { get => peso_max; set => peso_max = value; }
    public int Dexterity { get => Dexterity; set => Dexterity = value; }
    public int Xp { get => xp; set => xp = value; }
    public int Xp_nextLevel { get => xp_nextLevel; set => xp_nextLevel = value; }
    public int Level { get => level; set => level = value; }
    public Sprite Sprite { get => sprite; set => sprite = value; }
    public string Name { get => name; set => name = value; }
}
