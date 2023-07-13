using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    [SerializeField] private GameObject[] lightObj;

    private void Update()
    {
        StartCoroutine(EMarkerGrid());
    }

    public IEnumerator EMarkerGrid()
    {
        int count = 0;

        while (count < 3)
        {
            for (int i = 0; i < 6; i++)
            {
                lightObj[i].SetActive(false);
            }
            yield return new WaitForSeconds(3f);
            for (int i = 0; i < 6; i++)
            {
                lightObj[i].SetActive(true);
            }
            yield return new WaitForSeconds(3f);
            count++;
        }
    }
}
