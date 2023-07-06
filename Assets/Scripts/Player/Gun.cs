using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] public string gunName;
    [SerializeField] public float range;
    [SerializeField] public float fireRate;
    [SerializeField] public float reloadTime;

    [SerializeField] public ParticleSystem muzzleFlash;

    [SerializeField] public AudioClip fire_Sound;
}
