using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class Generateobjects : MonoBehaviour {

    public GameObject cross;
    private GameObject findobject;

    public GameObject[] objects;

    public int objNum;
    public int objCount = 0;
    public List<GameObject> randomObject;
    public List<GameObject> randomObject2;
    public Material[] randomMaterials;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
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

        if (Input.GetKeyDown(KeyCode.S))
        {
            RandomObject();
        }
    }

    public void RandomObject()
    {
        Debug.Log("Clicked");
        objNum = Random.Range(0, objects.Length);
        objCount = 0;
        //while (objCount < objects.Length)
        //{
            if(objCount < objects.Length)
            {
            randomObject[objCount].SetActive(false);
            objCount += 1;
            }
        //}
        randomObject2[objNum].SetActive(true);
        randomObject2[objNum].GetComponent<MeshRenderer>().material = randomObject[objNum].GetComponent<MeshRenderer>().material;
    }

    //public void NewRandomObject()
    //{
    //    objNum = Random.Range(0, objects.Length);
    //    // Deactivate old gameobject
    //    objects[objCount].SetActive(false);
    //    // Activate new gameobject
    //    objCount = objNum;
    //    objects[objCount].SetActive(true);
    //}
}
