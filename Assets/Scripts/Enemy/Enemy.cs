using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EnemyController
{
    public static Enemy Instance {  get; private set; }

    private void Start()
    {
        Instance = this;
        if (this.gameObject.activeSelf)
        {
            anim.SetTrigger("OnSpawn");
        }
    }

    private void Update()
    {
        enemyHpbar.value = (float)curHealth / maxHealth;
        nav.SetDestination(playerFos.position);
        transform.LookAt(playerFos.position);
    }

    public void OnHit(int dmg)
    {
        curHealth -= dmg;

        if (curHealth <= 0)
        {
            this.gameObject.SetActive(false);
            Debug.Log(gameObject.activeSelf);
            ObjectPool.instance._Queue.Enqueue(this.gameObject);
            anim.SetTrigger("OnDie");
            //spawn.isTrue = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("Hit!");
            Bullet bulletLogic = other.GetComponent<Bullet>();
            OnHit(bulletLogic.damage);
        }
    }
}
