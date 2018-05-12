using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour {
    public float mouseSensitivity = 10;
    public Transform target;
    public float dstFromTarget = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.position = target.position - transform.forward * dstFromTarget;
	}
} 
