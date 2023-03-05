using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHurtBox : MonoBehaviour, HurtBoxInterface
{
    EnemyManager enemyManager;
    void Start()
    {
        enemyManager = GetComponentInParent<EnemyManager>();
    }
    public void getDmg(int dmg)
    {
        enemyManager.receiveDmg(dmg);
    }


}
