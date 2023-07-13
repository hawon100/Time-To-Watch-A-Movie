using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SelectUI : MonoBehaviour
{
    [SerializeField] private VideoPlayer viewVideoPlayer;

    private void Start()
    {
        viewVideoPlayer.Play();
    }
}
