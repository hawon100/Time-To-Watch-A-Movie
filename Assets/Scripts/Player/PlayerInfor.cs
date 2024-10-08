using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfor : PlayerController
{
    private void OnHit(float dmg)
    {
        uiManager.curHealth -= dmg;

        if(uiManager.curHealth <= 0)
            uiManager.curHealth = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Enemy enemyLogic = other.gameObject.GetComponent<Enemy>();
            OnHit(enemyLogic.damage);
        }
    }
}
