using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class SelectUI : MonoBehaviour
{
    [SerializeField] private VideoPlayer viewVideoPlayer;
    [SerializeField] private StageUnLock[] stageUnlock;
    [SerializeField] private Button[] buttonLock; 

    private void Start()
    {
        viewVideoPlayer.Play();
    }

    private void Update()
    {
        ButtonLock();
    }

    private void ButtonLock()
    {
        for(int i = 0; i < 6; i++)
        {
            if (stageUnlock[i].isDead == true) buttonLock[i].enabled = true;
            else if (stageUnlock[i].isDead == false) buttonLock[i].enabled = false;
        }
    }
}
