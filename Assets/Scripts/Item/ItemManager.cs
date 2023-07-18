using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private GameObject itemPopcorn;
    [SerializeField] private GameObject itemGun;
    [SerializeField] private AudioClip shakeSound;

    bool isTrue;

    private void Start()
    {
        isTrue = true;
    }

    private void Update()
    {
        if (!itemPopcorn.activeSelf)
        {
            if (isTrue)
            {
                SoundManager.Instance.SFXPlay("Shake", shakeSound);
                isTrue = false;
            }
        }
    }
}
