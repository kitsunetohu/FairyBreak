using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampIntaract : MonoBehaviour,Interactable
{
    [SerializeField] GameObject pointLightRef;

    // Start is called before the first frame update
    void Start()
    {
        //pointLightRef = GameObject.Find("Point Light");    
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 外からアクションされた際の動作
    public void onActivate()
    {
        // 電気がついていたら
        if (pointLightRef.activeSelf)
        {
            // 電気消す。
            pointLightRef.SetActive(false);
            
        }
        else {
            // 電気つける。
            pointLightRef.SetActive(true);
            EventClasses.Instance.suprise.Invoke();
        }
    }

    public void InteractWithUser(){
        onActivate();
    }

    // トリガーを離したときに呼ぶ想定
 //   public void onTriggerDeactivate()
 //   {
 //       // 電気つける。
 //       pointLightRef.SetActive(true);
 //   }


}
