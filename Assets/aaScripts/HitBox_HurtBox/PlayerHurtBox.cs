using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurtBox : MonoBehaviour, HurtBoxInterface
{
    PlayerManager playerManager;
    void Start()
    {
        playerManager = GetComponentInParent<PlayerManager>();
    }
    public void getDmg(int dmg)
    {
        playerManager.getDmg(dmg);
    }

}
