using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    PlayerManager playerManager;
    private void Start()
    {
        playerManager = GetComponentInParent<PlayerManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HurtBoxInterface box = collision.GetComponent<HurtBoxInterface>();
        box.getDmg(playerManager.getAttackDmg());
    }




}
