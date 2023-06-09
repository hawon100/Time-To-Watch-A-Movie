using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject enemyObj;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if(!enemyObj.activeSelf)
        {
            anim.SetTrigger("OnDie");
        }
        else if (enemyObj.activeSelf)
        {
            anim.SetTrigger("OnSpawn");
        }
    }
}
