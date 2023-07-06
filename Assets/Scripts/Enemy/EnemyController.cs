using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public Spawn spawn;
    [SerializeField] public Slider enemyHpbar;
    [SerializeField] public NavMeshAgent nav;
    [SerializeField] public Transform playerFos;
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int curHealth;
    [SerializeField] public Animator anim;
    [SerializeField] public int damage;
}
