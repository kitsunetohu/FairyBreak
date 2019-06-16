using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // use attached game object location
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            SceneManager.LoadScene("Scenes");
        }
    }



}
