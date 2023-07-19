using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearUI : MonoBehaviour
{
    public void Home()
    {
        LoadingSceneController.LoadScene("Menu");
    }

    public void Next()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Ingame 0": LoadingSceneController.LoadScene("Ingame 1"); break;
            case "Ingame 1": LoadingSceneController.LoadScene("Ingame 2"); break;
            case "Ingame 2": LoadingSceneController.LoadScene("Ingame 3"); break;
            case "Ingame 3": LoadingSceneController.LoadScene("Ingame 4"); break;
            case "Ingame 4": LoadingSceneController.LoadScene("Ingame 5"); break;
            case "Ingame 5": LoadingSceneController.LoadScene("Ingame 6"); break;
            case "Ingame 6": break;
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
