using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialsDemo : MonoBehaviour {

    public GameObject[] coloredWalls;
    public Material[] randomMaterials;

    // Use this for initialization
    void Start()
    {
        coloredWalls[0].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[1].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[2].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[3].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[4].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[5].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[6].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[7].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[8].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[9].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[10].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[11].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[12].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[13].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)]; 
        coloredWalls[14].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)];


        if (coloredWalls[0].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
             coloredWalls[21].GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[1].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[22].GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[2].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[23].GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[3].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[24].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[4].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[25].GetComponent<MeshRenderer>().material = coloredWalls[4].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[5].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[26].GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[6].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[27].GetComponent<MeshRenderer>().material = coloredWalls[6].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[7].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[28].GetComponent<MeshRenderer>().material = coloredWalls[7].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[8].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[29].GetComponent<MeshRenderer>().material = coloredWalls[8].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[9].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[30].GetComponent<MeshRenderer>().material = coloredWalls[9].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[10].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[31].GetComponent<MeshRenderer>().material = coloredWalls[10].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[11].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[32].GetComponent<MeshRenderer>().material = coloredWalls[11].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[12].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[33].GetComponent<MeshRenderer>().material = coloredWalls[12].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[13].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[34].GetComponent<MeshRenderer>().material = coloredWalls[13].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[14].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[35].GetComponent<MeshRenderer>().material = coloredWalls[14].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[15].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[36].GetComponent<MeshRenderer>().material = coloredWalls[15].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[16].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[37].GetComponent<MeshRenderer>().material = coloredWalls[16].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[17].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[38].GetComponent<MeshRenderer>().material = coloredWalls[17].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[18].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[39].GetComponent<MeshRenderer>().material = coloredWalls[18].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[19].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[40].GetComponent<MeshRenderer>().material = coloredWalls[19].GetComponent<MeshRenderer>().material;
        }

        if (coloredWalls[20].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        {
            coloredWalls[41].GetComponent<MeshRenderer>().material = coloredWalls[20].GetComponent<MeshRenderer>().material;
        }
    }
}
