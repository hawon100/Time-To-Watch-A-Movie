using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnter : MonoBehaviour
{
    [SerializeField] private UIController uiCtrl;
    [SerializeField] private GameObject itemStart;

    private void Update()
    {
        if(!itemStart.activeSelf)
        {
            MovieLight();
        }
    }

    private void MovieLight()
    {
        uiCtrl.MovieLight();
    }
}
