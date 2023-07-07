using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] protected Light gameLight;
    [SerializeField] protected Text countText;

    [SerializeField] protected Slider playerStamina;
    [SerializeField] protected Slider playerHealth;

    [SerializeField] protected float countNum;
    [HideInInspector] public bool isStop;

    [SerializeField] public float curStamina;
    [SerializeField] public int maxStamina;

    [SerializeField] public float curHealth;
    [SerializeField] protected int maxHealth;

    [SerializeField] protected GameObject movieLight;
    [HideInInspector] protected int lightNum;

    [SerializeField] protected GameObject gameOver;
    [SerializeField] protected GameObject gameClear;
    [SerializeField] protected Text gameOverstageNum;
    [SerializeField] protected Text gameClearstageNum;
}
