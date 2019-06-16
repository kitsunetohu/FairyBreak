using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="yuko"){
            
            GetComponentInParent<Animator>().SetBool("openDoor",true);
            TextFile.instance.startTalk(1);
            Debug.Log("win");
            other.gameObject.GetComponent<Animator>().CrossFade("Standing@loop",0.1f,0,0);
            SceneManager.LoadScene("EndingScene");
        }
    }
}
