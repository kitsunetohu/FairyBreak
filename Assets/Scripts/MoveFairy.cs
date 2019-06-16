using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFairy : MonoBehaviour
{
    public float speed;
    [SerializeField] private GameObject center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (OVRInput.GetDown(OVRInput.Button.Three)) {
            pos+=speed*center.transform.forward;
            
        }
        transform.position =pos;
        
        
    }
}
