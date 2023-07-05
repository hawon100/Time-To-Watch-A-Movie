using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Gun currentGun;
    private float currentFireRate;

    private RaycastHit hitInfo;

    [SerializeField] private Camera cam;

    private Vector3 originPos;

    private void Start()
    {
        originPos = Vector3.zero;
    }

    private void Update()
    {
        GunFireRateCalc();
        TryFire();
    }

    private void GunFireRateCalc()
    {
        if(currentFireRate > 0)
        {
            currentFireRate -= Time.deltaTime;
        }
    }

    private void TryFire()
    {
        if(Input.GetButtonDown("Fire1") && currentFireRate <= 0)
        {
            Fire();
        }
    }

    private void Fire()
    {
        currentFireRate = currentGun.fireRate;
        Shoot();
    }

    private void Shoot()
    {
        SoundManager.Instance.SFXPlay("Fire", currentGun.fire_Sound);
        currentGun.muzzleFlash.Play();
        Hit();
    }

    private void Hit()
    {
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, currentGun.range))
        {
            Debug.Log(hitInfo.transform.name);
            if(hitInfo.transform.name == "Enemy")
            {

            }
        }
    }
}
