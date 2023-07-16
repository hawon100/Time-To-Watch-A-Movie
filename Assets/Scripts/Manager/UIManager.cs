using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] protected GameManager gameManager;

    [SerializeField] protected Slider playerStamina;
    [SerializeField] protected Slider playerHealth;

    [HideInInspector] public bool isStop;

    [SerializeField] public float curStamina;
    [SerializeField] public int maxStamina;

    [SerializeField] public float curHealth;
    [SerializeField] protected int maxHealth;

    [SerializeField] protected GameObject movieLight;
    [SerializeField] protected int lightNum;

    [SerializeField] protected float nightTime;
    [SerializeField] protected float waitTime;

    [SerializeField] protected GameObject gameOver;
    [SerializeField] protected GameObject gameClear;
    [SerializeField] protected Text gameOverstageNum;
    [SerializeField] protected Text gameClearstageNum;

    [SerializeField] protected GameObject weaponLight;

    [SerializeField] protected GameObject weaponGun;
    [SerializeField] protected ItemGun item;

    [SerializeField] protected GameObject player;

    [SerializeField] protected Camera mainCam;
    [SerializeField] protected Camera gameActiveCam;
}
