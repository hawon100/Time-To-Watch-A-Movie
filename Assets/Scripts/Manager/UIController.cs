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
    }

    void Update()
    {
        StateCal();
        WeaponLight();
        GameOver();
        ItemManager();
    }

    public void GameClear()
    {
        gameManager.isActive = true;
        gameClear.SetActive(true);
        mainCam.gameObject.SetActive(false);
        gameActiveCam.gameObject.SetActive(true);
    }

    private void GameOver()
    {
        if (curHealth <= 0)
        {
            gameOver.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            player.SetActive(false);
            mainCam.gameObject.SetActive(false);
            gameActiveCam.gameObject.SetActive(true);
        }
    }

    private void ItemManager()
    {
        if (item.isGun)
        {
            weaponGun.SetActive(true);
        }
    }

    private void WeaponLight()
    {
        if(!movieLight.activeSelf)
        {
            weaponLight.SetActive(true);
        }
    }

    public void MovieLight()
    {
        if (lightNum >= 3)
        {
            StopCoroutine(LightDirect());
        }
        else
        {
            StartCoroutine(LightDirect());
        }
    }

    private void StateCal()
    {
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

    private IEnumerator LightDirect()
    {
        if (lightNum <= 0)
        {
            yield return new WaitForSeconds(waitTime);
        }

        movieLight.SetActive(true);

        yield return new WaitForSeconds(nightTime);

        movieLight.SetActive(false);

        lightNum++;

        yield return new WaitForSeconds(nightTime);
    }
}
