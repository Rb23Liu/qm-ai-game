using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����
public class PickupItem : MonoBehaviour
{
    // ��Ч
    public GameObject pickupEffect;
    // ����
    public Item item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ��������������
        if(collision.tag == "Player")
        {
            Instantiate(pickupEffect,transform.position, Quaternion.identity);
            GameManager._instance.AddItem(item);
            Destroy(gameObject);
        }
    }
}
