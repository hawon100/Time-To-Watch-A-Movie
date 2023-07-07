using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearUI : MonoBehaviour
{
    public void Home()
    {
        LoadingSceneController.LoadScene("Menu");
    }

    public void Next()
    {
        LoadingSceneController.LoadScene("Ingame");
    }
}
