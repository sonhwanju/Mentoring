using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    //6��1�� ���丵
    //�÷��� : /����Ʈ, /ť, /����, / �ؽ����̺�, / ��ųʸ�, /��̸���Ʈ

    ArrayList arrayList = new ArrayList();

    Queue<int> queue = new Queue<int>(); //���Լ���
    Stack<int> stack = new Stack<int>(); //���Լ���

    List<int> list = new List<int>();

    Dictionary<int,string> dictionary = new Dictionary<int,string>();

    Hashtable hastable = new Hashtable();

    void Start()
    {
        //arrayList.Add(1);
        //arrayList.Add("��");

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
        //dictionary.Add(3, "����");
        

        //hastable.Add("string", 3);
    }

    void Update()
    {
        
    }
}
