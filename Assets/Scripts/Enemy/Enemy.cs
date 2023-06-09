using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EnemyManager
{
    private void Update()
    {
        if(nav.enabled) nav.SetDestination(playerFos.position);
        transform.LookAt(playerFos.position);
    }

    void OnHit(int dmg)
    {
        curHealth -= dmg;
        enemyHpbar.value = (float)curHealth / maxHealth;

        if (curHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerBullet"))
        {
            Bullet bullet = other.gameObject.GetComponent<Bullet>();
            OnHit(bullet.damage);
            Destroy(other.gameObject);
        }
    }
}
