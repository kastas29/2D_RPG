using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public static Equipment Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public EquipmentContent equipmentContent;
    public UpdateInventory updateInventory;


    public delegate void OnEquipmentChanged();
    public OnEquipmentChanged onEquipmentChanged;

    // agrega un equipo al equipamiento del personaje
    public void addEquip(Equip equip)
    {
        int slot = (int)equip.equipType;
        if (equipmentContent.CharacterEquipment[slot] != null)
        {
            Inventory.Instance.removeItem(equip);
            Inventory.Instance.addItem(equipmentContent.CharacterEquipment[slot]);
            equipmentContent.CharacterEquipment[slot] = equip;
        }
        else
        {
            Inventory.Instance.removeItem(equip);
            equipmentContent.CharacterEquipment[slot] = equip;
        }
        onEquipmentChanged?.Invoke();
    }

    // desequipa un equipo del personaje
    public void desEquip(Equip equip)
    {
        if (Inventory.Instance.addItem(equip))
        {
            equipmentContent.CharacterEquipment[(int)equip.equipType] = null;
            onEquipmentChanged?.Invoke();
        }
    }

    // agrega una mochila al equipamiento
    public void addBackpack(Backpack backPack)
    {
        int num = Array.IndexOf(equipmentContent.Backpacks, null);



        if (Array.IndexOf(equipmentContent.Backpacks, null) != -1)
        {
            Inventory.Instance.removeItem(backPack);
            equipmentContent.Backpacks[Array.IndexOf(equipmentContent.Backpacks, null)] = backPack;
            updateInventory.addSlot(backPack.space);
        }

        onEquipmentChanged?.Invoke();
    }

    // borra una mochila del equipamiento
    public void removeBackpack(Backpack backPack)
    {
        if (updateInventory.removeSlot(backPack.space))
        {
            Inventory.Instance.addItem(backPack);
            equipmentContent.Backpacks[Array.IndexOf(equipmentContent.Backpacks, backPack)] = null;

        }
        onEquipmentChanged?.Invoke();
    }


    // devuelve el tamaño de las mochilas
    public int getBackpacksCapacity()
    {
        int backpackCapacity = 0;
        for (int i = 0; i < equipmentContent.Backpacks.Length; i++)
        {
            if (equipmentContent.Backpacks[i] != null)
            {
                backpackCapacity += equipmentContent.Backpacks[i].space;
            }

        }
        print("BACKPAKS SPACE:" + backpackCapacity);
        return backpackCapacity;
    }



    //Funciones que devulven los stats de los items.
    public int getEquipmentHp()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].hp;
            }
        }
        return value;
    }
    public int getEquipmentStamina()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].stamina;
            }
        }
        return value;
    }
    public int getEquipmentMana()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].mana;
            }
        }
        return value;
    }
    public int getEquipmentDmg()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].dmg;
            }
        }
        return value;
    }
    public int getEquipmentSpeed()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].speed;
            }
        }
        return value;
    }
    public int getEquipmentCriticalDmg()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].criticalDmg;
            }
        }
        return value;
    }
    public int getEquipmentCriticalPercent()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].criticalPercent;
            }
        }
        return value;
    }
    public int getEquipmentCriticalRes()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].criticalResistance;
            }
        }
        return value;
    }
    public int getEquipmentArmor()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].armor;
            }
        }
        return value;
    }
    public int getEquipmentShield()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].shield;
            }
        }
        return value;
    }
    public int getEquipmentMind()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].Mind;
            }
        }
        return value;
    }
    public int getEquipmentDexterity()
    {
        int value = 0;
        for (int i = 0; i < equipmentContent.CharacterEquipment.Length; i++)
        {
            if (equipmentContent.CharacterEquipment[i] != null)
            {
                value += equipmentContent.CharacterEquipment[i].Dexterity;
            }
        }
        return value;
    }
    // fin
}
