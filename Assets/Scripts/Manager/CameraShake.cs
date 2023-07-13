using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float shakeTime;
    [SerializeField] private float shakeSpeed;
    [SerializeField] private float shakeAmount;
    [SerializeField] private Camera camera;
    [HideInInspector] private Transform camPos;
    [SerializeField] private GameObject itemStart;
    [HideInInspector] private bool isActive;

    private void Start()
    {
        isActive = true;
        camPos = camera.transform;
    }

    private void Update()
    {
        if(isActive)
        {
            if (!itemStart.activeSelf)
            {
                StartCoroutine(Shake());
                isActive = false;
            }
        }
    }

    private IEnumerator Shake()
    {
        Vector3 originPos = camPos.localPosition;
        float elapsedTime = 0.0f;

        while(elapsedTime < shakeTime)
        {
            Vector3 randomPoiunt = originPos + Random.insideUnitSphere * shakeAmount;
            camPos.localPosition = Vector3.Lerp(camPos.localPosition, randomPoiunt, Time.deltaTime * shakeSpeed);
            yield return null;
            elapsedTime += Time.deltaTime;
        }
        camPos.localPosition = originPos;
    }
}
