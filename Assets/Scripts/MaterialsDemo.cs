using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialsDemo : MonoBehaviour {

    public GameObject[] coloredWalls;
    public Material[] randomMaterials;
    int color1 = 0;
    int color2 = 1;
    int color3 = 2;
    int color4 = 3;
    int color5 = 4;

    // Use this for initialization
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
        { 
            //see all objects
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

            if (coloredWalls[0].GetComponent<MeshRenderer>().material = randomMaterials[num])
            {
                GameObject game = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Cube2");
                game.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
                GameObject game2 = GameObject.Find("RandomColor/BookShelf/Cube (8)/Cube (8)/Cube (1)");
                game2.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
                GameObject game3 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Cube3");
                game3.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
                GameObject game4 = GameObject.Find("RandomColor/BookShelf2/Cube (9)/Group3/Cube4");
                game4.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
                GameObject game5 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Cube (2)");
                game5.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
            }

            if (coloredWalls[1].GetComponent<MeshRenderer>().material = randomMaterials[num])
            {
                GameObject game = GameObject.Find("RandomColor/BookShelf/Cube (8)/Cube (8)/Sphere (1)");
                game.GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
                GameObject game2 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Sphere");
                game2.GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
                coloredWalls[22].GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
                coloredWalls[28].GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
                coloredWalls[37].GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
            }

        }





        //if (coloredWalls[2].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        //{
        //    coloredWalls[9].GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        //    coloredWalls[15].GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        //    coloredWalls[23].GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        //    coloredWalls[30].GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        //    coloredWalls[36].GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        //}

        //if (coloredWalls[3].GetComponent<MeshRenderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)])
        //{
        //    coloredWalls[4].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[5].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[6].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[10].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[11].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[12].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[13].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[17].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[18].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[19].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[20].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[24].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[25].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[26].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[27].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[31].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[32].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[33].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[34].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[38].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[39].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[40].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //    coloredWalls[41].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        //}
    }
}
