using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class gunScript : MonoBehaviour {

    AudioSource audio;
    public static gunScript instance;
    // Use this for initialization

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    void Start () {
        audio = GetComponent<AudioSource>();
	}

    public void fireSound() {
        audio.Play();

    }
	// Update is called once per frame
	void Update () {
		
	}
}
