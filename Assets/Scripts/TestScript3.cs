using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TestScript3 : MonoBehaviour
{
    float x;
    void Start()
    {
        ChSceneManager.instance.ChangeScene("Scene2");
    }
    void Update()
    {
        transform.DOMove(new Vector3(0,0,0), 2f).SetLoops(5);
    }
    /*






        transform

        transform.DoMove(Vector3 목표값, float 변화시간, (bool 정수단위 이동여부));
        transform.DoRotate(Vector3 목표값, float 변화시간, (RotateMode 회전방식));
        transform.DoScale(Vector3 목표값, float 변화시간);

        transform.DoLocalMove(...); //로컬 좌표 이동
        transform.DoMoveX(...); //x축 이동

        material

        .DoColor(Color 목표값, float 변화시간)
        .DOFade(float 목표값, float 변화시간)

        text

        .DoText(string 전체텍스트, float 변화시간, (...))

        sequence
        
        
        추가 : .Append(Tween 트윈); //마지막에 추가 = add
        삽입 : .Insert(float 삽입시간, Tween 트윈); //순서와 관계없이 일정 지점에 시작
        결합 : .Join(Tween 트윈); //앞에 추가된 트윈과 동시 시작
        접두 : .Prepend(Tween 트윈); // 맨 처음에 추가

        //딜레이를 추가하고 싶을때 쓴다.
        .AppendInterval(float 딜레이); //뒤에 추가
        .PrependInterval(float 딜레이); //맨 앞에 추가

        시퀀스는 트윈 + 트윈만아니라 시퀀스끼리의 결합도가능하다.
    */
}
