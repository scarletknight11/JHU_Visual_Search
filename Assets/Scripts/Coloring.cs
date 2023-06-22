using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
    public Material[] randomMaterials;
    public GameObject[] coloredWalls;

    void Start()
    {
        //Simple way: create int array for indicate assign material
        int[] indMat = new int[randomMaterials.Length];
        //Just in case we initialize an array
        for (int i = 0; i < randomMaterials.Length; i++)
        {
            indMat[i] = 0; //not assign material
        }

        foreach (GameObject wall in coloredWalls)
        { //see all objects
          //Assign random material to object
            int num = Random.Range(0, randomMaterials.Length);
            //already apply, find next
            while (indMat[num] != 0)
            {
                num++;
                if (num >= randomMaterials.Length)
                {
                    num = 0;
                }
            }
            indMat[num] = 1;
            wall.GetComponent<MeshRenderer>().material = randomMaterials[num];
        }
    }
}
