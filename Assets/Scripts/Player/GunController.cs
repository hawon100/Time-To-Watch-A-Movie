using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    static public GunController instance {  get; private set; }

    [SerializeField] private Spawn spawnScript;

    [SerializeField] private Gun currentGun;
    private float currentFireRate;

    private RaycastHit hitInfo;

    [SerializeField] private Camera cam;
    [SerializeField] public int damage;

    private Vector3 originPos;

    private void Start()
    {
        instance = this;
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
        StartCoroutine(Hit());
    }

    private IEnumerator Hit()
    {
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, currentGun.range))
        {
            GameObject hitEtf = ObjectPool.instance._Queue1.Dequeue();
            GameObject bullet = ObjectPool.instance._Queue2.Dequeue();

            ObjectPool.instance._Queue1.Enqueue(hitEtf);
            ObjectPool.instance._Queue2.Enqueue(bullet);

            hitEtf.transform.position = hitInfo.point;
            hitEtf.transform.rotation = Quaternion.LookRotation(hitInfo.normal);
            hitEtf.SetActive(true);

            
            bullet.transform.position = hitInfo.point;
            bullet.transform.rotation = Quaternion.LookRotation(hitInfo.normal);
            bullet.SetActive(true);

            if (hitEtf.activeSelf)
            {
                yield return new WaitForSeconds(0.5f);
                hitEtf.SetActive(false);
            }
            if (bullet.activeSelf)
            {
                yield return new WaitForSeconds(0.5f);
                bullet.SetActive(false);
            }
        }
    }
}
