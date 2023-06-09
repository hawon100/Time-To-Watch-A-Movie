using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoint;
    [SerializeField] private ObjectPool objectPool;
    [SerializeField] private string[] objName;

    private void Awake()
    {
        GameObject enemy = objectPool.MakeObj("Enemy");
        enemy.transform.position = spawnPoint[0].position;
    }
}
