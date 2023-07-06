using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private Light gameLight;
    [SerializeField] private Text countText;

    [SerializeField] private Slider playerStamina;
    [SerializeField] private Slider playerHealth;

    [SerializeField] private float countNum;
    [HideInInspector] public bool isStop;

    [SerializeField] public float curStamina;
    [SerializeField] private int maxStamina;

    [SerializeField] private float curHealth;
    [SerializeField] private int maxHealth;

    private void Start()
    {
        Instance = this;
        isStop = true;
        gameLight.transform.rotation = Quaternion.Euler(20f, 0f, 0f);
    }

    void Update()
    {
        StartTime();
        StaminaCal();
        HealthCal();
    }

    private void HealthCal()
    {
        playerHealth.value = curHealth / maxHealth;
    }

    private void StaminaCal()
    {
        playerStamina.value = curStamina / maxStamina;
    }

    private void StartTime()
    {
        TimerCal();
        TimerStop();
        countText.text = (int)countNum + "초 후 시작됩니다.";
    }

    private void TimerStop()
    {
        if (countNum <= 0)
        {
            countText.gameObject.SetActive(false);
            isStop = false;
            countNum = 0;
        }
    }

    private void TimerCal()
    {
        if (isStop)
        {
            StartCoroutine(Timer());
        }
        if (!isStop)
        {
            StopCoroutine(Timer());
        }
    }


    private IEnumerator Timer()
    {
        countNum -= Time.deltaTime;

        yield return new WaitForSeconds(1f);
    }
}
