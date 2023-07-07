using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public static Spawn Instance { get; private set; }

    [SerializeField] private Spawn spawn;
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] private Transform playerFos;
    [SerializeField] private Animator anim;
    [SerializeField] public Slider enemyHpbar;
    [SerializeField] public UIManager startUI;
    [HideInInspector] public bool isTrue;

    private void Start()
    {
        //isTrue = true;
        Instance = this;
    }

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
            enemyLogic.spawn = spawn;

            isTrue = false;
        }
    }
}
