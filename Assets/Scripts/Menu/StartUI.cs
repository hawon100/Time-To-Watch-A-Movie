using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class StartUI : MonoBehaviour
{
    [SerializeField] private VideoPlayer viewVideoPlayer;
    [SerializeField] private GameObject CreditWindowObj;
    [SerializeField] private GameObject HowtoPlayWindowObj;
    [SerializeField] private GameObject SettingWindowObj;

    private void Start() 
    {
        viewVideoPlayer.Play();
    }

    private void Update()
    {
        if(CreditWindowObj.activeSelf && Input.GetMouseButtonDown(1))
        {
            CreditWindowObj.SetActive(false);
        }
        if (HowtoPlayWindowObj.activeSelf && Input.GetMouseButtonDown(1))
        {
            HowtoPlayWindowObj.SetActive(false);
        }
        if (SettingWindowObj.activeSelf && Input.GetMouseButtonDown(1))
        {
            SettingWindowObj.SetActive(false);
        }
    }

    public void GameStart()
    {
        LoadingSceneController.LoadScene("StageSelect");
    }

    public void GameHowto()
    {
        HowtoPlayWindowObj.SetActive(true);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void GameSetting()
    {
        SettingWindowObj.SetActive(true);
    }

    public void GameCredit()
    {
        CreditWindowObj.SetActive(true);
    }
}
