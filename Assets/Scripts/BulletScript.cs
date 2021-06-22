using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int speed = 5;



    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Wall")) {
            gameObject.SetActive(false);
        }
    }
}
