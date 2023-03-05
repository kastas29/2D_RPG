using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitBox : MonoBehaviour
{
    EnemyManager enemyManager;
    bool attackCool;
    private void Start()
    {
        enemyManager = GetComponentInParent<EnemyManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (attackCool)
        {
            attackCool = false;
            HurtBoxInterface box = collision.GetComponent<HurtBoxInterface>();
            box.getDmg(enemyManager.getAttackDmg());
            StartCoroutine(attack());

        }
    }

    IEnumerator attack()
    {
        yield return new WaitForSeconds(5);
        attackCool = true;
    }
}
