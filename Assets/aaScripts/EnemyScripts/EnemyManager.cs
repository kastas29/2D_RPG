using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [SerializeField] EnemyStats enemyStats;
    [SerializeField] Loot[] lootTable;
    [SerializeField] GameObject item;
    [SerializeField] GameObject deadParticles;
    [SerializeField] Transform playerPosition;
    [SerializeField] Rigidbody2D rigidBody;
    public GameObject player;


    private void Start()
    {
        transform.GetComponent<SpriteRenderer>().sprite = enemyStats.Sprite;
        rigidBody = GetComponentInParent<Rigidbody2D>();
        playerPosition = PlayerManager.Instance.gameObject.transform;

    }
    [Serializable]
    public struct Loot
    {
        public Item itemSO;
        public float probabilitat;
    }

    private void Update()
    {


        if (player != null)
        {
            rotate();
            aggro();
        }


    }

    public void rotate()
    {
        if (playerPosition.position.x < this.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(Vector3.up * 180);
        }
        else if (playerPosition.transform.position.x > this.transform.position.x)
        {
            transform.rotation = Quaternion.identity;
        }
    }

    void aggro()
    {
        if (playerPosition.position.x > this.transform.position.x)
        {
            rigidBody.velocity = new Vector2(5, 0);
            GetComponentInParent<Transform>().localRotation = new Quaternion(0, 0, 0, 0);
        }
        if (playerPosition.position.x < this.transform.position.x)
        {
            rigidBody.velocity = new Vector2(-5, 0);
            GetComponentInParent<Transform>().localRotation = new Quaternion(0, 180, 0, 0);
        }
        if (playerPosition.position.y > this.transform.position.y)
        {
            rigidBody.velocity = new Vector2(0, 5);
        }
        if (playerPosition.position.y < this.transform.position.y)
        {
            rigidBody.velocity = new Vector2(0, -5);
        }
    }

    public void receiveDmg(int dmg)
    {
        transform.GetComponent<ParticleSystem>().Play();
        enemyStats.Hp -= dmg;
        if (enemyStats.Hp <= 0)
        {
            Instantiate(deadParticles, transform.position, Quaternion.identity);
            morir();
        }
    }

    public void morir()
    {
        GetComponent<AudioSource>().Play();
        PlayerManager.Instance.receiveExperience(enemyStats.Level * 100);
        foreach (Loot lootItem in lootTable)
        {
            float r = UnityEngine.Random.Range(0, 1f);
            if (lootItem.probabilitat > r)
            {
                GameObject newItem = item;
                newItem.GetComponent<SpriteRenderer>().sprite = lootItem.itemSO.sprite;
                newItem.GetComponent<ItemScript>().item = lootItem.itemSO;
                newItem.transform.localScale = new Vector3(3, 3, 0);
                Instantiate(item, transform.position, Quaternion.identity);
            }
        }
        Destroy(this.gameObject);
    }

    public int getAttackDmg()
    {
        int attackDmg = 0;
        if (getCriticalAttack() > UnityEngine.Random.Range(0, 1f))
        {
            attackDmg = enemyStats.Dmg + enemyStats.CriticalDmg;
        }
        else
        {
            attackDmg = enemyStats.Dmg;
        }
        print("Enemy ATTACK DMG: " + attackDmg);
        return attackDmg;
    }

    public float getCriticalAttack()
    {
        float criticalPercent = enemyStats.CriticalPercent / 100;
        print("Enemy CRITICAL PERCENT: " + criticalPercent);
        return criticalPercent;
    }

}
