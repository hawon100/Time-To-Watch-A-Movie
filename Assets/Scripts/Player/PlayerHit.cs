using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    [SerializeField] private UIController uiCirl;

    float timer;
    int waitingTime;

    private void Start()
    {
        timer = 0.0f;
        waitingTime = 2;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            HealthDecrease();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            HealthDecrease();
        }
    }

    private void HealthDecrease()
    {
        timer += Time.deltaTime;

        if(timer > waitingTime)
        {
            uiCirl.curHealth -= 2;

            timer = 0;
        }
    }
}
