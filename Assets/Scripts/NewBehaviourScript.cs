using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    private Transform TargetFocus;
    public static birdcontroller instance;
    //public float speed = 15f;
    // Use this for initialization
    void Start()
    {
        TargetFocus = GameObject.FindGameObjectWithTag("target").transform;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = TargetFocus.position - this.transform.position;
        //
        float speed=15f;
        
        Debug.Log("PIKAQIU");
        Debug.Log(speed);

        if (target.magnitude < 1)
        {
            targetcollider.instance.moveTarget();
        }
        transform.LookAt(TargetFocus.transform);
        //float speed =15f;
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}