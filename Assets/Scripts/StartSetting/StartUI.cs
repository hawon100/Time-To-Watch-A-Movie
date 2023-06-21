using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUI : MonoBehaviour
{
    public static StartUI Instance { get; private set; }

    [SerializeField] private Light gameLight;
    [SerializeField] private Text countText;

    [SerializeField] private float countNum;
    [HideInInspector] public bool isStop;

    private void Start()
    {
        Instance = this;
        isStop = true;
        gameLight.transform.rotation = Quaternion.Euler(-20f, 0f, 0f);
    }

    void Update()
    {
        TimerCal();
        TimerStop();
        countText.text = (int)countNum + "초 후 정전됩니다.";
    }

    private void TimerStop()
    {
        if (countNum <= 0)
        {
            countText.gameObject.SetActive(false);
            gameLight.transform.rotation = Quaternion.Euler(-20f, 0f, 0f);
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
