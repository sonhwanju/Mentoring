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
    }


    void Start()
    {
        
    }

    IEnumerator SpawnBullet() {
        while(true) {
            if(Input.GetButtonDown("Fire1")) {
                //여기서 생성을 해준다.

            }
            yield return ws;
        }
        
    }
}
