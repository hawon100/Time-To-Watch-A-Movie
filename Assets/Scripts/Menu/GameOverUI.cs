using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public void Home()
    {
        LoadingSceneController.LoadScene("Menu");
    }

    public void Retry()
    {
        LoadingSceneController.LoadScene("Ingame");
    }
}
