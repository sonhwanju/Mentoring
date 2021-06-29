using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    private WaitForSeconds ws = new WaitForSeconds(0.5f);
    void Awake()
    {
        //여기서 미리 생성해준다. 생성해줄때의 부모는 지금 이 스크립트가 달려있는 플레이어로한다.
        TestScript1.CreatePool<PoolObj>(bulletPrefab, this.transform);

    }


    void Start()
    {
        StartCoroutine(SpawnBullet());
    }

    IEnumerator SpawnBullet() {
        while(true) {
            if(Input.GetButton("Fire1")) {
                Debug.Log("에이 시팔");

                PoolObj Obj = TestScript1.GetItem<PoolObj>();
                Debug.Log("에이 시팔2");

                // shootObj.gameObject.SetActive(true);
            }
            yield return ws;
        }
        
    }
}
