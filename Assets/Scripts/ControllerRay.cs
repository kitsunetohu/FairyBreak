﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRay : MonoBehaviour
{
    [SerializeField] private GameObject pointer;
    [SerializeField] private GameObject camera;

    private Collider preCollider;
    private Collider preCollider2;

    private bool emphasize=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 1f);
        if (hit.point != Vector3.zero) // Vector3 is non-nullable; comparing to null is always false
		{
			pointer.transform.position = hit.point;
		}
		else
		{
			pointer.transform.position = ray.GetPoint(3.0f);
		}
        if (OVRInput.GetDown(OVRInput.Button.One) && hit.collider.tag == "point"){
            hit.collider.gameObject.SetActive(false);
            camera.transform.position = hit.point;
            preCollider.gameObject.SetActive(true);
            preCollider = hit.collider;
        }
        if (hit.collider.tag == "interact"){
            if(!emphasize){
                hit.collider.gameObject.GetComponent<Outline>().enabled = true;
                preCollider2 = hit.collider;
                emphasize = true;
            }
            if (OVRInput.GetDown(OVRInput.Button.One)){
                hit.collider.gameObject.GetComponent<Interactable>().InteractWithUser();
            }
        }else if(emphasize){
            preCollider2.gameObject.GetComponent<Outline>().enabled = false;
            emphasize = false;
        }
    }
}
