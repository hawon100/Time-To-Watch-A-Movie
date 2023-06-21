using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class UIManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer viewVideoPlayer;

    private void Start() 
    {
        viewVideoPlayer.Play();
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

    }
}
