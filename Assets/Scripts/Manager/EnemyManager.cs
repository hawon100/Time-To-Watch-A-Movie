using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] protected Slider enemyHpbar;
    [SerializeField] protected NavMeshAgent nav;
    [SerializeField] protected Transform playerFos;
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int curHealth;
}
