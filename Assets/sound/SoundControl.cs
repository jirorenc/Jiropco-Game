using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {
    public AudioClip yurume;
    public  GameObject jiro;
    public  GameObject diken;
    private float jiry, jirz,jirx;
    public Transform firstStart;
    public Transform secondStart;
    AudioSource aSource;
    private bool kontrol;
	// Use this for initialization
	void Start () {
        aSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        SoundC();
        jirz=jiro.transform.position.z;
        jiry=jiro.transform.position.y;
        jirx=jiro.transform.position.x;
        if ((jirz < 17 && jirz > 6) && jiry < 3.8f)
        {
            jiro.transform.position= firstStart.position;
        }
        if ((jirz < 246&& jirz > 238) && jiry < 3.8f)
        {
            jiro.transform.position = secondStart.position;
        }
        else if (jirz < 280&&jirz>165 && jiry < -5)
        {
            jiro.transform.position = secondStart.position;
        }
        else if (jirz <=165 && jiry < -5)
        {
            jiro.transform.position = firstStart.position;
           
        }
        
	}
    void SoundC()
    {
        
        if (Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            aSource.Play();
        }
        else if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            aSource.Pause();
        }
    }
}
