using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float num;
    [SerializeField] private GameObject interactImage;

    private void Start()
    {
        interactImage.SetActive(false);
    }

    private void Update()
    {
        ItemRotate();
        InteractKeyInput();
    }

    private void InteractKeyInput()
    {
        if (interactImage.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                this.gameObject.SetActive(false);
                interactImage.SetActive(false);
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
