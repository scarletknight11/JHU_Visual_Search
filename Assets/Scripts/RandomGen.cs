using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGen : MonoBehaviour {

    public GameObject[] objects;
    public int objNum;
    public int objCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            objNum = Random.Range(0, objects.Length);
            objCount = 0;
            while (objCount < objects.Length)
            {
                objects[objCount].SetActive(false);
                objCount += 1;
            }
            objects[objNum].SetActive(true);
        }
    }
}
