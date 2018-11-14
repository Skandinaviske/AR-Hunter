using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdcontroller : MonoBehaviour {

    private Transform TargetFocus;
    public static birdcontroller instance;
    //public float speed = 15f;
    // Use this for initialization
    void Start () {
        TargetFocus = GameObject.FindGameObjectWithTag("target").transform;
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 target = TargetFocus.position - this.transform.position;
        //
        float speed;
        if (gameController.instance.round == 1)
            speed = 15f;
        else if (gameController.instance.round == 2)
            speed = 30f;
        else if (gameController.instance.round == 3)
            speed = 45f;
        else if (gameController.instance.round == 4)
            speed = 60f;
        else speed = 100f;
        Debug.Log("PIKAQIU");
        Debug.Log (speed);
       
        if (target.magnitude < 1) {
            targetcollider.instance.moveTarget();
        }
        transform.LookAt(TargetFocus.transform);
        //float speed =15f;
        transform.Translate(0, 0, speed * Time.deltaTime);
	}
}
