using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ChestManager : MonoBehaviour
{
    public Loot[] lootTable;
    public GameObject item;
    [Serializable]
    public struct Loot
    {
        public Item itemSO;
        public float probabilitat;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            morir();
        }
    }

    void morir()
    {
        foreach (Loot lootItem in lootTable)
        {
            float r = UnityEngine.Random.Range(0, 1f);
            if (lootItem.probabilitat >= r)
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
}
