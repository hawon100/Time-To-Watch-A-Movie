using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // [SerializeField] private GameObject bullet;
    // [SerializeField] private float curShotDelay;
    // [SerializeField] private float maxShotDelay;
    [SerializeField] private Camera fpsCam;
    [SerializeField] private GameObject pistol;
    [SerializeField] private GameObject playerObj;
    //[SerializeField] private float bulletSpeed;

    private void Update()
    {
        // Fire();
        // Reload();
        Follow();
    }

    void Follow()
    {
        
    }

    // void Fire()
    // {
    //     if(!Input.GetMouseButtonDown(0))
    //         return;
    //     if (curShotDelay < maxShotDelay)
    //         return;
        
    //     GameObject bullets = Instantiate(bullet, transform.position + Vector3.up * 0.5f, transform.rotation);
    //     Rigidbody rigidBullet = bullets.GetComponent<Rigidbody>();
    //     rigidBullet.AddForce(fpsCam.transform.forward * bulletSpeed, ForceMode.Impulse);
    //     rigidBullet.rotation = fpsCam.transform.rotation;

    //     curShotDelay = 0;
    // }

    // void Reload()
    // {
    //     curShotDelay += Time.deltaTime;
    // }
}
