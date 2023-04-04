using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour {

    Vector3 coordinates;
    Vector3 coordinates2;
    public GameObject[] ObjectToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        coordinates =  new Vector3(1.0f, 1.0f, 1.0f);
        coordinates2 = new Vector3(10.0f, 10.0f, 10.0f);

        // Random position between 2 vectors
        float x = Random.Range(coordinates.x, coordinates2.x);
        float y = Random.Range(coordinates.y, coordinates2.y);
        float z = Random.Range(coordinates.z, coordinates2.z);

        float x2 = Random.Range(coordinates.x, coordinates2.x);
        float y2 = Random.Range(coordinates.y, coordinates2.y);
        float z2 = Random.Range(coordinates.z, coordinates2.z);

        float x3 = Random.Range(coordinates.x, coordinates2.x);
        float y3 = Random.Range(coordinates.y, coordinates2.y);
        float z3 = Random.Range(coordinates.z, coordinates2.z);

        float x4 = Random.Range(coordinates.x, coordinates2.x);
        float y4 = Random.Range(coordinates.y, coordinates2.y);
        float z4 = Random.Range(coordinates.z, coordinates2.z);

        float x5 = Random.Range(coordinates.x, coordinates2.x);
        float y5 = Random.Range(coordinates.y, coordinates2.y);
        float z5 = Random.Range(coordinates.z, coordinates2.z);

        float x6 = Random.Range(coordinates.x, coordinates2.x);
        float y6 = Random.Range(coordinates.y, coordinates2.y);
        float z6 = Random.Range(coordinates.z, coordinates2.z);

        ObjectToSpawn[0].transform.position = new Vector3(x, y, z);
        ObjectToSpawn[1].transform.position = new Vector3(x2, y2, z2);
        ObjectToSpawn[2].transform.position = new Vector3(x3, y3, z3);
        ObjectToSpawn[3].transform.position = new Vector3(x4, y4, z4);
        ObjectToSpawn[4].transform.position = new Vector3(x5, y5, z5);
        ObjectToSpawn[5].transform.position = new Vector3(x6, y6, z6);
    }
}
