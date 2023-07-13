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
        transform.LookAt(playerFos.position);

        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerFos.position, moveSpeed * Time.deltaTime);
    }

    public void OnHit(int dmg)
    {
        curHealth -= dmg;

        if (curHealth <= 0)
        {
            this.gameObject.SetActive(false);
            //Debug.Log(gameObject.activeSelf);
            ObjectPool.instance._Queue.Enqueue(this.gameObject);
            anim.SetTrigger("OnDie");
            uiCtrl.GameClear();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerBullet"))
        {
            Bullet bulletLogic = other.GetComponent<Bullet>();
            OnHit(bulletLogic.damage);
        }
    }
}
