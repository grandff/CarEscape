using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    /*
        공장을 만드는 방법
        1) 이미 있는 오브젝트를 사용해 프리팹을 만듬
        2) 제너레이터 스크립트를 만듬
        3) 빈 오브젝트에 제너레이터 스크립트 적용
        4) 제너레이터 스크립트에 프리맵 전달
    */

    public GameObject arrowPrefab;
    float span = 0.5f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;   // 앞 프레임과 현재 프레임 사이의 시간차이를 Time.deltaTime에 대입
        if(this.delta > this.span){
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject; // 화살 인스턴스 생성
            int px = Random.Range(-6, 7);   // Range 메서드를 활용해 화살의 x 좌표를 불규칙하게 위치시킴
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
