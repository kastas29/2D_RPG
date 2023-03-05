using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Potion : Item
{
    [SerializeField] int hp_recovery;

    public override void use()
    {
        GameManager.Instance.GetComponent<LifeManager>().setHp(hp_recovery);
        Inventory.Instance.removeItem(this);
    }
}

