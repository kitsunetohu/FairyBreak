using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFile : MonoBehaviour
{
    public static TextFile instance;
    [SerializeField]
     string[] seeString;
    [SerializeField]
     string[] thankString;
    string[] nowString;
    float t=0;
    int i=0;
    bool isPrepared;
    IEnumerator stringIEnu;

    GameObject gui; //guiのオブジェクト
    GuiTextMessage script; //GuiTextMessageスクリプトが入る変数

    // Use this for initialization
    void Start()
    {
        instance=this;
        gui = GameObject.Find("GUI"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = gui.GetComponent<GuiTextMessage>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        isPrepared=false;
        
    }

    // Update is called once per frame
    void Update()
    {if(isPrepared==true){
        t+=Time.deltaTime;
        //電気つけたときとか。
        if (t>2.5)
        {
            if(stringIEnu.MoveNext()){
                script.setTextWithTime(stringIEnu.Current as string, 2);
                t=0;
            }else 
            {
                isPrepared=false;
            }
        }
    }
        
    }

    public void startTalk(int num){
        
        if(num==0){
            nowString=seeString;
        }else if(num==1)
        {
            nowString=thankString;
            Debug.Log("thamk");
        }
        stringIEnu=nowString.GetEnumerator();
        t=0;
        isPrepared=true;

    }

    public void sendOneMessage(string m){
        script.setTextWithTime(m, 2);
    }
}
