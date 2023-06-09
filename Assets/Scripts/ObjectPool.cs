using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject objPrefab;

    GameObject[] prefab;

    GameObject[] targetPool;

    private void Awake()
    {
        prefab = new GameObject[10];

        Generate();
    }

    void Generate()
    {
        for (int i = 0; i < prefab.Length; i++)
        {
            prefab[i] = Instantiate(objPrefab);
            prefab[i].SetActive(false);
        }
    }

    public GameObject MakeObj(string type)
    {
        switch (type)
        {
            case "Enemy":
                targetPool = prefab;
                break;
        }

        for (int i = 0; i < targetPool.Length; i++)
        {
            if (!targetPool[i].activeSelf)
            {
                targetPool[i].SetActive(true);
                return targetPool[i];
            }
        }

        return null;
    }

    public GameObject[] GetPool(string type)
    {
        switch (type)
        {
            case "Enemy":
                targetPool = prefab;
                break;
        }

        return targetPool;
    }
}
