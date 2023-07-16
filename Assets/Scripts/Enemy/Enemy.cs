using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : EnemyController
{
    public static Enemy Instance { get; private set; }

    private void Start()
    {
        Instance = this;
        if (this.gameObject.activeSelf)
        {
            anim.SetTrigger("OnSpawn");
        }

        switch (SceneManager.GetActiveScene().name)
        {
            case "Ingame 0": maxHealth = 100; curHealth = 100; break;
            case "Ingame 1": maxHealth = 200; curHealth = 200; break;
            case "Ingame 2": maxHealth = 300; curHealth = 300; break;
            case "Ingame 3": maxHealth = 400; curHealth = 400; break;
            case "Ingame 4": maxHealth = 500; curHealth = 500; break;
            case "Ingame 5": maxHealth = 600; curHealth = 600; break;
            case "Ingame 6": maxHealth = 700; curHealth = 700; break;
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
        if (Vector3.Distance(playerFos.position, transform.position) <= 15f)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, playerFos.position, moveSpeed * Time.deltaTime);
    }

    public void OnHit(int dmg)
    {
        curHealth -= dmg;

        if (curHealth <= 0)
        {
            this.gameObject.SetActive(false);
            ObjectPool.instance._Queue.Enqueue(this.gameObject);
            anim.SetTrigger("OnDie");
            uiCtrl.GameClear();


            switch (SceneManager.GetActiveScene().name)
            {
                case "Ingame 0": enemyDatas[1].isDead = true; break;
                case "Ingame 1": enemyDatas[2].isDead = true; break;
                case "Ingame 2": enemyDatas[3].isDead = true; break;
                case "Ingame 3": enemyDatas[4].isDead = true; break;
                case "Ingame 4": enemyDatas[5].isDead = true; break;
                case "Ingame 5": enemyDatas[6].isDead = true; break;
                case "Ingame 6":  break;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            Bullet bulletLogic = other.GetComponent<Bullet>();
            OnHit(bulletLogic.damage);
        }
    }
}
