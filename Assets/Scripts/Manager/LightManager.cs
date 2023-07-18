using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    [SerializeField] private GameObject[] lightObj;

    private void Start()
    {
        StartCoroutine(EMarkerGrid());
    }

    public IEnumerator EMarkerGrid()
    {
        while (true)
        {
            int random = Random.Range(0, 6);

            lightObj[random].SetActive(false);
            yield return new WaitForSeconds(2f);
            lightObj[random].SetActive(true);
            yield return new WaitForSeconds(2f);
        }
    }
}
