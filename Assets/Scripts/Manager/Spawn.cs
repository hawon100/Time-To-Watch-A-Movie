using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GunController gun;
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] private Transform playerFos;
    [SerializeField] private Animator anim;
    [SerializeField] public Slider enemyHpbar;
    [SerializeField] public UIManager startUI;

    public static bool isTrue = true;

    private void Update()
    {
        if (isTrue && !startUI.isStop)
        {
            GameObject enemy = ObjectPool.instance._Queue.Dequeue();
            ObjectPool.instance._Queue.Enqueue(enemy);

            enemy.transform.position = spawnPoint[0].position;
            enemy.SetActive(true);
            Enemy enemyLogic = enemy.GetComponent<Enemy>();
            enemyLogic.playerFos = playerFos;
            enemyLogic.enemyHpbar = enemyHpbar;
            enemyLogic.anim = anim;

            isTrue = false;
        }
    }
}
