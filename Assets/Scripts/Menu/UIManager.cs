using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UIManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer viewVideoPlayer;
    [SerializeField] private GameObject CreditWindowObj;

    private void Start() 
    {
        viewVideoPlayer.Play();
    }

    private void Update()
    {
        if(CreditWindowObj.activeSelf && Input.GetMouseButtonDown(0))
        {
            CreditWindowObj.SetActive(false);
        }
    }

    public void GameStart()
    {
        LoadingSceneController.LoadScene("Ingame");
    }

    public void GameHowto()
    {

    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void GameSetting()
    {
        
    }

    public void GameCredit()
    {
        CreditWindowObj.SetActive(true);
    }
}
