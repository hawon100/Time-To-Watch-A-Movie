using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : PlayerController
{
    [SerializeField] protected float walkSpeed;
    [SerializeField] protected float runSpeed;
    protected float applySpeed;

    protected bool isRun = false;

    private void Awake()
    {
        applySpeed = walkSpeed;
    }

    private void Update()
    {
        TryRun();
        Move();
    }

    private void TryRun()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (uiManager.curStamina > 0))
        {
            applySpeed = runSpeed;
            MoveStamina();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            applySpeed = walkSpeed;
        }

        if (applySpeed != runSpeed)
        {
            uiManager.curStamina += Time.deltaTime / 2f;
        }
    }

    private void Move()
    {
        float _moveDirX = Input.GetAxisRaw("Horizontal");
        float _moveDirZ = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _moveDirX;
        Vector3 _moveVertical = transform.forward * _moveDirZ;

        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * applySpeed;

        myRigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    }

    private void MoveStamina()
    {
        uiManager.curStamina -= Time.deltaTime;
    }
}
