using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript1 : MonoBehaviour
{
    public static Dictionary<string,object> pool = new Dictionary<string, object>();
    public static Dictionary<string,GameObject> prefabDic = new Dictionary<string, GameObject>();

//prefab : 생성할 프리팹 parent : 어디를 부모로 할 것인가 count : 디폴트값은 5, 카운트만큼 미리 생성해둔다
    public static void CreatePool<T>(GameObject prefab,Transform parent,int count = 5) {
        Queue<T> q = new Queue<T>();
        for(int i = 0; i < count; i++) {
            GameObject obj = GameObject.Instantiate(prefab,parent);

            //Bullet bullet = obj.GetComponent<Bullet>();
            T t = obj.GetComponent<T>();
            obj.SetActive(false);
            q.Enqueue(t);
        }
        //Bullet ->  "Bullet"
        string key = typeof(T).ToString();
        pool.Add(key,q);
        prefabDic.Add(key,prefab);
    }

    public static T GetItem<T>() where T : MonoBehaviour
    {
        string key = typeof(T).ToString();
        T item = null;

        if(pool.ContainsKey(key))
        {
            Queue<T> q = (Queue<T>)pool[key];
            T firstItem = q.Peek();

            if(firstItem.gameObject.activeSelf)
            {
                GameObject prefab = prefabDic[key];
                GameObject g = GameObject.Instantiate(prefab, firstItem.transform.parent);
                item = g.GetComponent<T>();
            }
            else
            {
                item = q.Dequeue();
                item.gameObject.SetActive(true);
            }
            q.Enqueue(item);
        }

        return item;
    }
}
