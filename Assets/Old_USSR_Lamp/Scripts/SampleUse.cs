using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleUse : MonoBehaviour
{

    GameObject gui; //guiのオブジェクト
    LampIntaract script; //LampIntaractスクリプトが入る変数

    // Start is called before the first frame update
    void Start()
    {
        gui = GameObject.Find("Lamp"); // GUIオブジェクトの検索
        script = gui.GetComponent<LampIntaract>(); // LampIntaractスクリプトをget
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // lampにアクションを与える
            script.onActivate();
        }

    }
}
