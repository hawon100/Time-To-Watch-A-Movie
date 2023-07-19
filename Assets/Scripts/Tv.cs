using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tv : MonoBehaviour
{
    [SerializeField] private Material[] mat;

    private void Start()
    {
        StartCoroutine(VideoPlay());
    }

    private IEnumerator VideoPlay()
    {
        while (true)
        {
            for (int i = 0; i < 6; i++)
            {
                this.GetComponent<MeshRenderer>().material = mat[i];
                yield return new WaitForSeconds(1f);
            }
            break;
        }
    }
}
