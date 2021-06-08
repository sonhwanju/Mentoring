using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObj : MonoBehaviour
{
    [SerializeField]
    private int hp = 5;
    
    IEnumerator mHp()
    {
        while (true)
        {
            hp--;

            if(hp <= 0)
            {
                PoolManager.instance.InsertQueue(gameObject);
            }

            yield return new WaitForSeconds(1f);
        }
    }
    private void OnEnable()
    {
        hp = 5;
        StartCoroutine(mHp());
    }
}
