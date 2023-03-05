using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTemplateManager : MonoBehaviour
{

    public Sprite[] skinList = new Sprite[4];

    [SerializeField] CharacterStats characterStats;
    [SerializeField] BaseStats baseStats;
    [SerializeField] InventoryContent inventory;
    [SerializeField] EquipmentContent equipment;



    public void ChangeSkin(string role)
    {
        switch (role)
        {
            case "Warrior":
                this.GetComponent<SpriteRenderer>().sprite = skinList[0];
                characterStats.Sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
            case "Archer":
                this.GetComponent<SpriteRenderer>().sprite = skinList[1];
                characterStats.Sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
            case "Wizard":
                this.GetComponent<SpriteRenderer>().sprite = skinList[2];
                characterStats.Sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
            case "Assassin":
                this.GetComponent<SpriteRenderer>().sprite = skinList[3];
                characterStats.Sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
        }
        startCharacterStats();
    }

    public void changeNameString(GameObject InputField)
    {
        characterStats.Name = InputField.GetComponent<TextMeshProUGUI>().text.ToUpper();
    }

    public void startCharacterStats()
    {

        characterStats.Hp_max = baseStats.Hp;
        characterStats.Stamina_max = baseStats.Stamina;
        characterStats.Stamina_regenVelocity = baseStats.Stamina_regenVelocity;
        characterStats.Mana_max = baseStats.Mana;
        characterStats.Mana_regenVelocity = baseStats.Mana_regenVelocity;
        characterStats.Dmg = baseStats.Dmg;
        characterStats.Speed = baseStats.Speed;
        characterStats.CriticalDmg = baseStats.CriticalDmg;
        characterStats.CriticalPercent = baseStats.CriticalPercent;
        characterStats.CriticalResistance = baseStats.CriticalResistance;
        characterStats.Armor = baseStats.Armor;
        characterStats.Shield_max = baseStats.Shield;
        characterStats.DamagePercent = baseStats.DamagePercent;
        characterStats.Peso_max = baseStats.Peso;
        characterStats.Xp = baseStats.Xp;
        characterStats.Level = baseStats.Level;
        characterStats.Xp_nextLevel = baseStats.Level;

        inventory.InventoryMaxCapacity = 105;
        inventory.Items.Clear();

        equipment.CharacterEquipment = new Equip[8];
        equipment.Backpacks = new Backpack[4];

    }

}
