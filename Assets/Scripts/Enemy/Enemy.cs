using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EnemyController
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

    public void OnHit(int dmg)
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

    private void ATKRange()
    {
        
    }

    private void Attack()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerBullet"))
        {
            Bullet bulletLogic = other.GetComponent<Bullet>();
            OnHit(bulletLogic.damage);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (sphereCollider.gameObject.CompareTag("Player"))
        {

        }
    }
}
