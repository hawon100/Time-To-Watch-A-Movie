using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPointView : PlayerController
{
    [SerializeField] private float lookSensitivity;
    [SerializeField] private float cameraRotationLimit;
    [SerializeField] private float lightRotationLimitX;
    [SerializeField] private float lightRotationLimitY;
    private float currentCameraRotationX;
    private float currentLightRotationX;
    private float currentLightRotationY;

    [SerializeField] private Camera theCamera;
    [SerializeField] private Light Lentern;

    private void Update()
    {
        CharacterRotation();
        CameraRotation();
        LightRotation();
    }

    private void CharacterRotation()
    {
        //cam move
        float _yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 _characterRotationY = new Vector3(0f, _yRotation, 0f) * lookSensitivity;
        myRigid.MoveRotation(myRigid.rotation * Quaternion.Euler(_characterRotationY));
    }

    private void CameraRotation()
    {
        //cam move
        float _xRotation = Input.GetAxisRaw("Mouse Y");
        float _cameraRotationX = _xRotation * lookSensitivity;
        currentCameraRotationX -= _cameraRotationX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);

    }

    private void LightRotation()
    {
        float _yRotation = Input.GetAxisRaw("Mouse X");
        float _lightRotationY = _yRotation * lookSensitivity;
        currentLightRotationY -= _lightRotationY;
        currentLightRotationY = Mathf.Clamp(currentLightRotationY, -lightRotationLimitY, lightRotationLimitY);

        float _xRotation = Input.GetAxisRaw("Mouse Y");
        float _lightRotationX = _xRotation * lookSensitivity;
        currentLightRotationX -= _lightRotationX;
        currentLightRotationX = Mathf.Clamp(currentLightRotationX, -lightRotationLimitX, lightRotationLimitX);

        Lentern.transform.localEulerAngles = new Vector3(currentLightRotationX, currentLightRotationY, 0f);
    }
}
