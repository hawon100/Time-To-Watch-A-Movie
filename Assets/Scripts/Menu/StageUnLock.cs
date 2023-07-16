using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Enemy Data", menuName = "Scriptable Object/Enemy Data", order = int.MaxValue)]
public class StageUnLock : ScriptableObject
{
    [SerializeField] private string enemyName;
    public string EnemyName { get { return enemyName; } }
    [SerializeField] public bool isDead;
}