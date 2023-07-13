using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] protected Spawn spawn;
    [SerializeField] protected Transform[] spawnPoint;
    [SerializeField] protected Transform playerFos;
    [SerializeField] protected Animator anim;
    [SerializeField] public Slider enemyHpbar;
    [SerializeField] public UIController uiCtrl;
    [HideInInspector] public bool isTrue;
    [SerializeField] protected GameObject movieLight;
}
