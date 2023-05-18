using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllingVR : MonoBehaviour {

    public GameObject cross;
    private GameObject findobject;



    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            Time.timeScale = 1.0f;
            cross.SetActive(false);
            findobject = transform.GetChild(0).gameObject;
            findobject.SetActive(true);
            findobject = transform.GetChild(1).gameObject;
            findobject.SetActive(true);
            findobject = transform.GetChild(2).gameObject;
            findobject.SetActive(true);
            findobject = transform.GetChild(3).gameObject;
            findobject.SetActive(true);
            findobject = transform.GetChild(4).gameObject;
            findobject.SetActive(true);
        }
    }
}
