using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : SpawnManager
{
    public static Spawn Instance { get; private set; }

    [SerializeField] private AudioClip spawnClip;
    [SerializeField] private float timer = 0.0f;

    private void Start()
    {
        isTrue = true;
        Instance = this;

    }

    private void Update()
    {
        SpawnFunc();

        if(!movieLight.activeSelf)
        {
            StartCoroutine(SpawnTimer());
        }
        if (timer >= 10f)
        {
            StopCoroutine(SpawnTimer());
        }
    }

    private void SpawnFunc()
    {
        if(isTrue)
        {
            if (!movieLight.activeSelf && timer >= 10)
            {
                GameObject enemy = ObjectPool.instance._Queue.Dequeue();
                ObjectPool.instance._Queue.Enqueue(enemy);

                SoundManager.Instance.SFXPlay("Spawn", spawnClip);

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

    private IEnumerator SpawnTimer()
    {
        timer += Time.deltaTime;
        yield return new WaitForSeconds(1f);
    }
}
