using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaterial : MonoBehaviour {

    public Material[] randomMaterials;
    public GameObject[] coloredWalls;

    void Start()
    {
        foreach (GameObject wall in coloredWalls)
        { //see all objects
          //Assign random material to object
            wall.GetComponent<Renderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)];
        }
    }




}
