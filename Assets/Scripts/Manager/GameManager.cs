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

    [SerializeField] private Text[] mission;
    [SerializeField] private int interactionA;
    [SerializeField] private int interactionB;

    [SerializeField] private GameObject[] item;
    
    void Start()
    {
        Instance = this;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

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
        QuestText();
    }

    private void QuestText()
    {
        if (!item[0].activeSelf)
        {
            interactionA = 1;
        }
        if (!item[1].activeSelf)
        {
            interactionB = 1;
        }

        mission[0].text = "ÆËÄÜ ¸Ô±â " + interactionA + " / 1";
        mission[1].text = "  ÃÑ È¹µæ " + interactionB + " / 1";
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
