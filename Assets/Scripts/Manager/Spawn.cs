using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : SpawnManager
{
    public static Spawn Instance { get; private set; }

    private void Start()
    {
        isTrue = true;
        Instance = this;
    }

    private void Update()
    {
        SpawnFunc();
    }

    private void SpawnFunc()
    {
        if(isTrue)
        {
            if (!movieLight.activeSelf)
            {
                GameObject enemy = ObjectPool.instance._Queue.Dequeue();
                ObjectPool.instance._Queue.Enqueue(enemy);

                enemy.transform.position = spawnPoint[0].position;
                enemy.SetActive(true);
                Enemy enemyLogic = enemy.GetComponent<Enemy>();
                enemyLogic.playerFos = playerFos;
                enemyLogic.enemyHpbar = enemyHpbar;
                enemyLogic.anim = anim;
                enemyLogic.spawn = spawn;
                enemyLogic.uiCtrl = uiCtrl;

                isTrue = false;
            }
        }
    }
}
