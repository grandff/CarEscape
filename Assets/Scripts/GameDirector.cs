using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauage;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauage = GameObject.Find("hpGauge");     // find 메서드로 hp 오브젝트 찾음
    }

    public void DecreaseHP(){
        this.hpGauage.GetComponent<Image>().fillAmount -= 0.1f;     // hp 게이지 비율 낮춤
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
