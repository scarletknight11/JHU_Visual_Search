using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_item : MonoBehaviour {

    public GameObject cube;
    public GameObject sphere;
    private bool used = false;


    // Update is called once per frame
    void Update()
    {
        if(!used && Input.GetKey(KeyCode.A))
        {
            Replace(cube, sphere);
            used = true;
        }
    }

    void Replace(GameObject obj1, GameObject obj2)
    {
        Instantiate(obj2, obj1.transform.position, Quaternion.identity);
        Destroy(obj1);
    }

}
