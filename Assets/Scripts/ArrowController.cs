using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 등속으로 낙하시킴
        transform.Translate(0, -0.1f, 0);

        // 화면 밖으로 나오면 오브젝트 소멸
        if(transform.position.y < -5.0f){
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;        // 화살 중심 좌표
        Vector2 p2 = this.player.transform.position;        // 플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;        // 화살 반경
        float r2 = 1.0f;        // 플레이어 반경

        if(d < r1 + r2){    // 충돌한 경우
            // 감독 스크립트에 플레이어와 화살이 충돌했다고 전달함
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            /*
                자신 이외의 오브젝트 컴포넌트에 접근하는 방법
                1) Find 메서드로 오브젝트 찾음
                2) GetComponent 메서드로 오브젝트의 컴포넌트를 구함
                3) 컴포넌트를 가진 데이터에 접근함
            */

            // 충돌한 경우 화살 지움
            Destroy(gameObject);
        }
    }
}
