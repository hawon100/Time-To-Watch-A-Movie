using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] private Transform playerFos;
    [SerializeField] private string[] objName;
    [SerializeField] private Animator anim;
    [SerializeField] public Slider enemyHpbar;
    [SerializeField] public StartUI startUI;

    public static bool isTrue = true;

    private void Update()
    {
        if (isTrue && !startUI.isStop)
        {
            GameObject enemy = ObjectPool.instance._Queue.Dequeue();
            enemy.transform.position = spawnPoint[0].position;
            enemy.SetActive(true);
            EnemyManager enemyLogic = enemy.GetComponent<EnemyManager>();
            enemyLogic.playerFos = playerFos;
            enemyLogic.enemyHpbar = enemyHpbar;
            enemyLogic.anim = anim;

            isTrue = false;
        }
    }
}
