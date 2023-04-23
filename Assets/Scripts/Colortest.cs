using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colortest : MonoBehaviour {

    //private Coloring c;
    public GameObject[] coloredWalls;
    public Material[] randomMaterials;

    // Start is called before the first frame update
    void Start()
    {
        coloredWalls[5] = GameObject.Find("Cube2");
        coloredWalls[5].GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;   
    }

}
