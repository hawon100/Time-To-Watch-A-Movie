using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    ItemGun,
    Bullet,
    Stamina,
    Health
}

public class Item : MonoBehaviour
{
    [SerializeField] private ItemType itemType;
    [SerializeField] private float num;

    private void Update()
    { 
        float temp = num * Time.deltaTime;
        transform.Rotate(temp, temp, temp);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
