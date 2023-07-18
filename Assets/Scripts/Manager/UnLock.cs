using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnLock : MonoBehaviour
{
    [SerializeField] private StageManager stageManager;
    [SerializeField] private StageUnLock[] stageUnLock;

    private void Update()
    {
        for(int i = 0; i < 7; i++)
        {
            stageUnLock[i].enemyName = stageManager.stageNames[i];
            stageUnLock[i].isDead = stageManager.isDead[i];
        }
    }
}
