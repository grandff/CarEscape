using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LButtonDown(){
        transform.Translate(-3, 0, 0);      // 왼쪽으로 3만큼 이동            
    }

    public void RButtonDown(){
        transform.Translate(3, 0, 0);       // 오른쪽으로 3만큼 이동
    }

    // Update is called once per frame
    void Update()
    {
        /*
        // 왼쪽 화살표가 눌렸을 때
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            
        }

        // 오른쪽 화살표가 눌렸을 때
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            
        }
        */
    }
}
