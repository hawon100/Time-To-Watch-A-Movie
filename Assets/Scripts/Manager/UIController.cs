using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : UIManager
{
    public static UIController Instance { get; private set; }

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
        GameOver();
    }

    public void GameClear()
    {
        gameClear.SetActive(true);
    }

    private void GameOver()
    {
        if(curHealth <= 0)
        {
            gameOver.SetActive(true);
        }
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

    private IEnumerator LightDirect()
    {
        if (lightNum == 3)
            StopCoroutine(LightDirect());

        movieLight.SetActive(true);

        yield return new WaitForSeconds(1f);

        movieLight.SetActive(false);

        yield return new WaitForSeconds(1f);

        lightNum++;
    }
}
