using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomPosition : MonoBehaviour {

    public GameObject[] ObjectToSpawn;
  
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        float PlaceX;
        float PlaceY;
        float PlaceZ;

        float PlaceX2;
        float PlaceY2;
        float PlaceZ2;

        float PlaceX3;
        float PlaceY3;
        float PlaceZ3;

        float PlaceX4;
        float PlaceY4;
        float PlaceZ4;

        float PlaceX5;
        float PlaceY5;
        float PlaceZ5;

        PlaceX = Random.Range(-3.7f, 0.852f);
        PlaceY = Random.Range(-0.007f, 0.2f);
        PlaceZ = Random.Range(-0.07f, 2.0f);
        PlaceX2 = Random.Range(-2.5214f, 1.05f);
        PlaceY2 = Random.Range(-0.0109f, 0.185f);
        PlaceZ2 = Random.Range(-0.07f, 0.076f);
        PlaceX3 = Random.Range(-2.5214f, 1.05f);
        PlaceY3 = Random.Range(-0.0109f, 0.185f);
        PlaceZ3 = Random.Range(-0.07f, 0.076f);
        PlaceX4 = Random.Range(-2.5214f, 1.05f);
        PlaceY4 = Random.Range(-0.0109f, 0.185f);
        PlaceZ4 = Random.Range(-0.07f, 0.076f);
        PlaceX5 = Random.Range(-2.5214f, 1.05f);
        PlaceY5 = Random.Range(-0.0109f, 0.185f);
        PlaceZ5 = Random.Range(-0.07f, 0.076f);

        ObjectToSpawn[0].transform.position = new Vector3(PlaceX, PlaceY, PlaceZ);
        ObjectToSpawn[1].transform.position = new Vector3(PlaceX2, PlaceY2, PlaceZ2);
        ObjectToSpawn[2].transform.position = new Vector3(PlaceX3, PlaceY3, PlaceZ3);
        ObjectToSpawn[3].transform.position = new Vector3(PlaceX4, PlaceY4, PlaceZ4);
        ObjectToSpawn[4].transform.position = new Vector3(PlaceX5, PlaceY5, PlaceZ5);
    }
}
