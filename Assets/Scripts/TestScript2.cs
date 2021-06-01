using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    //6월1일 멘토링
    //컬렉션 : /리스트, /큐, /스택, / 해시테이블, / 딕셔너리, /어레이리스트

    ArrayList arrayList = new ArrayList();

    Queue<int> queue = new Queue<int>(); //선입선출
    Stack<int> stack = new Stack<int>(); //후입선출

    List<int> list = new List<int>();

    Dictionary<int,string> dictionary = new Dictionary<int,string>();

    Hashtable hastable = new Hashtable();

    void Start()
    {
        //arrayList.Add(1);
        //arrayList.Add("일");

        //if(arrayList.Contains(1))
        //{
        //    Debug.Log("");
        //}

        //Debug.Log(arrayList);
        //Debug.Log(arrayList[0]);
        //arrayList.Remove(0);


        //foreach (var item in arrayList)
        //{
        //    Debug.Log(item);
        //}
        //queue.Enqueue(1);

        //if(queue.Count != 0)
        //{
        //    queue.Dequeue();
        //}
        //stack.Push(1);
        //stack.Pop();
        //stack.Clear();

        ////list.Add(8);
        //dictionary.Add(3, "주형");
        

        //hastable.Add("string", 3);
    }

    void Update()
    {
        
    }
}
