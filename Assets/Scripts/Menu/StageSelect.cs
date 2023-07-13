using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public void Stage1()
    {
        LoadingSceneController.LoadScene("Ingame");
    }

    public void Stage2()
    {
        LoadingSceneController.LoadScene("Ingame 1");
    }

    public void Home()
    {
        LoadingSceneController.LoadScene("Menu");
    }
}
