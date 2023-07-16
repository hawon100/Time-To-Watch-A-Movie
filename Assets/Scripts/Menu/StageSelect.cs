using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelect : MonoBehaviour
{
    public void Stage1() { LoadingSceneController.LoadScene("Ingame 0"); }
    public void Stage2() { LoadingSceneController.LoadScene("Ingame 1"); }
    public void Stage3() { LoadingSceneController.LoadScene("Ingame 2"); }
    public void Stage4() { LoadingSceneController.LoadScene("Ingame 3"); }
    public void Stage5() { LoadingSceneController.LoadScene("Ingame 4"); }
    public void Stage6() { LoadingSceneController.LoadScene("Ingame 5"); }
    public void Stage7() { LoadingSceneController.LoadScene("Ingame 6"); }

    public void Home()
    {
        LoadingSceneController.LoadScene("Menu");
    }
}
