using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class targetcollider : DefaultTrackableEventHandler {

    public static targetcollider instance;

    void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        moveTarget();   
    }

    public void moveTarget() {
        Vector3 temp;
        temp.x = Random.Range(-48f, 48f);
        temp.y = Random.Range(13f, 18f);
        temp.z = Random.Range(-48f, 48f);
        transform.position = new Vector3(temp.x, temp.y, temp.z);
        if (DefaultTrackableEventHandler.trueFalse == true)
        {
            RaycastController.instance.playSound(0);
        }
    }
}
