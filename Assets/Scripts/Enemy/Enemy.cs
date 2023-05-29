using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private NavMeshAgent nav;
    [SerializeField] private Transform playerFos;
    [SerializeField] private int health;

    private void Update()
    {
        nav.SetDestination(playerFos.position);
    }

    void OnHit(int dmg)
    {
        health -= dmg;

        if(health <= 0)
        {
            health = 0;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerBullet")
        {
            Bullet bullet = other.gameObject.GetComponent<Bullet>();
            OnHit(bullet.damage);
            Destroy(other.gameObject);
        }
    }
}
