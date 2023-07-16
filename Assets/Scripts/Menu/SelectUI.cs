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
        if (stageUnlock[0].isDead == true) buttonLock[0].enabled = true;
        if (stageUnlock[1].isDead == true) buttonLock[1].enabled = true;
        if (stageUnlock[2].isDead == true) buttonLock[2].enabled = true;
        if (stageUnlock[3].isDead == true) buttonLock[3].enabled = true;
        if (stageUnlock[4].isDead == true) buttonLock[4].enabled = true;
        if (stageUnlock[5].isDead == true) buttonLock[5].enabled = true;
        if (stageUnlock[6].isDead == true) buttonLock[6].enabled = true;
    }
}
