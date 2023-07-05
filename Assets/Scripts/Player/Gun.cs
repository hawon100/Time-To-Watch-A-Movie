using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] public string gunName;
    [SerializeField] public float range;
    [SerializeField] public float accuracy;
    [SerializeField] public float fireRate;
    [SerializeField] public float reloadTime;

    [SerializeField] public int damage;

    [SerializeField] public int reloadBulletCount;
    [SerializeField] public int currentBulletCount;
    [SerializeField] public int maxBulletCount;
    [SerializeField] public int carryBulletCount;

    [SerializeField] public float retroActionForce;
    [SerializeField] public float retroActionFineSightForce;

    [SerializeField] public Vector3 fineSightOriginpos;

    [SerializeField] public ParticleSystem muzzleFlash;

    [SerializeField] public AudioClip fire_Sound;
}
