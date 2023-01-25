using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.InputSystem;


public class Generateobjects : MonoBehaviour {

    public GameObject cross;
    //public GameObject[] objects;
    private GameObject findobject;

    void Start()
    {
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) 
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
            //objects[0].SetActive(true);
            //objects[1].SetActive(true);
            //objects[2].SetActive(true);
            //objects[3].SetActive(true);
            //objects[4].SetActive(true);
            //objects[5].SetActive(true);
        }
        

        

        

    }
}
