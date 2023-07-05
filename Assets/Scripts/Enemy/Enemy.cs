using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EnemyManager
{
    private void Update()
    {
        if(nav.enabled) nav.SetDestination(playerFos.position);
        transform.LookAt(playerFos.position);

        if (this.gameObject.activeSelf)
        {
            anim.SetTrigger("OnSpawn");
        }
    }

    void OnHit(int dmg)
    {
        curHealth -= dmg;
        enemyHpbar.value = (float)curHealth / maxHealth;

        if (curHealth <= 0)
        {
            this.gameObject.SetActive(false);
            Debug.Log(gameObject.activeSelf);
            ObjectPool.instance._Queue.Enqueue(this.gameObject);
            anim.SetTrigger("OnDie");
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
