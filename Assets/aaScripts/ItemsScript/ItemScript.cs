using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public Item item;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = item.sprite;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-60, 60), Random.Range(-60, 60)));
    }


    public void TakeItem()
    {
        if (Inventory.Instance.addItem(item))
        {
            Destroy(this.gameObject);
        }
    }
}
