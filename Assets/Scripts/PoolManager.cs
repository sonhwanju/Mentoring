using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager instance;

    private Queue<GameObject> poolQueue = new Queue<GameObject>();

    public GameObject poolPrefab;


    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(poolPrefab, this.gameObject.transform);
            InsertQueue(obj);
        }

        StartCoroutine(SpawnObj());
    }

    public void InsertQueue(GameObject obj)
    {
        poolQueue.Enqueue(obj);
        obj.SetActive(false);
    }

    public GameObject GetQueue()
    {
        GameObject obj = poolQueue.Dequeue();
        obj.SetActive(true);
        return obj;
    }

    IEnumerator SpawnObj()
    {
        while (true)
        {
            if(poolQueue.Count != 0)
            {
                GameObject obj = GetQueue();
                obj.transform.position = transform.position;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
