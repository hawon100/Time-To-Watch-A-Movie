using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private Text[] stageNum;
    [SerializeField] private Text nowStageNum;
    [SerializeField] private GameObject escapeWin;
    [SerializeField] public bool isActive;
    
    void Start()
    {
        Instance = this;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        switch (SceneManager.GetActiveScene().name)
        {
            case "Ingame 0": stageNum[0].text = "1"; stageNum[1].text = "1"; break;
            case "Ingame 1": stageNum[0].text = "2"; stageNum[1].text = "2"; break;
            case "Ingame 2": stageNum[0].text = "3"; stageNum[1].text = "3"; break;
            case "Ingame 3": stageNum[0].text = "4"; stageNum[1].text = "4"; break;
            case "Ingame 4": stageNum[0].text = "5"; stageNum[1].text = "5"; break;
            case "Ingame 5": stageNum[0].text = "6"; stageNum[1].text = "6"; break;
            case "Ingame 6": stageNum[0].text = "7"; stageNum[1].text = "7"; break;
        }

        nowStageNum.text = "Stage " + stageNum[0].text;
    }

    public void Home()
    {
        LoadingSceneController.LoadScene("Menu");
    }

    private void Update()
    {
        Escape();
        CursorActive();
    }

    private void CursorActive()
    {
        if (isActive)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (!isActive)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void Escape()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isActive = !isActive;
            escapeWin.SetActive(isActive);
        }
    }

    public void EscapeWinCmd()
    {
        isActive = !isActive;
        escapeWin.SetActive(isActive);
    }
}
