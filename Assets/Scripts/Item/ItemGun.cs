using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGun : MonoBehaviour
{
    public static ItemGun Instance { get; private set; }

    [SerializeField] private float num;
    [SerializeField] private GameObject interactImage;
    [HideInInspector] private string name;
    [HideInInspector] public bool isGun;

    private void Start()
    {
        isGun = false;
        Instance = this;
        interactImage.SetActive(false);
    }

    private void Update()
    {
        ItemRotate();
        InteractKeyInput();
    }

    private void InteractKeyInput()
    {
        if (interactImage.activeSelf && name == "Gun")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                interactImage.SetActive(false);
                isGun = true;
            }
        }
    }

    private void ItemRotate()
    {
        float temp = num * Time.deltaTime;
        transform.Rotate(temp, temp, temp);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            interactImage.SetActive(true);
            name = "Gun";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            interactImage.SetActive(false);
        }
    }
}
