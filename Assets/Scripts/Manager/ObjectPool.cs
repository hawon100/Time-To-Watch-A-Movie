using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class ObjectInfo
{
    public GameObject goPrefab;
    public int count;
    public Transform tfPoolParent;
}

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance { get; private set; }
    
    public ObjectInfo[] objectInfo = null;
    public Queue<GameObject> _Queue = new Queue<GameObject>();
    public Queue<GameObject> _Queue1 = new Queue<GameObject>();
    public Queue<GameObject> _Queue2 = new Queue<GameObject>();

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        _Queue = InsertQueue(objectInfo[0]);
        _Queue1 = InsertQueue(objectInfo[1]);
        _Queue2 = InsertQueue(objectInfo[2]);
    }

    Queue<GameObject> InsertQueue(ObjectInfo p_objectInfo)
    {
        Queue<GameObject> t_queue = new Queue<GameObject>();
        for(int i = 0; i < p_objectInfo.count; i++)
        {
            GameObject t_clone = Instantiate(p_objectInfo.goPrefab, transform.position, Quaternion.identity);
            t_clone.SetActive(false);
            if(p_objectInfo.tfPoolParent != null)
            {
                t_clone.transform.SetParent(p_objectInfo.tfPoolParent);
            }
            else
            {
                t_clone.transform.SetParent(this.transform);
            }
            t_queue.Enqueue(t_clone); 
        }

        return t_queue;
    }
}
