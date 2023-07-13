using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] protected float moveSpeed;
    [SerializeField] public Spawn spawn;
    [SerializeField] public Slider enemyHpbar;
    [SerializeField] public Transform playerFos;
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int curHealth;
    [SerializeField] public Animator anim;
    [SerializeField] public UIController uiCtrl;
    [SerializeField] public int damage;
}
