using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialsDemo : MonoBehaviour {

    public GameObject[] coloredWalls;
    public GameObject[] coloredWalls2;
    public List<GameObject> randomObject;
    public Material[] randomMaterials;

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
        }

        coloredWalls[3].GetComponent<MeshRenderer>().material = coloredWalls[4].GetComponent<MeshRenderer>().material;
        coloredWalls[5].GetComponent<MeshRenderer>().material = coloredWalls[6].GetComponent<MeshRenderer>().material;
        coloredWalls2[0].GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
        coloredWalls2[1].GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
        coloredWalls2[2].GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        coloredWalls2[3].GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        coloredWalls2[4].GetComponent<MeshRenderer>().material = coloredWalls[6].GetComponent<MeshRenderer>().material;
        coloredWalls2[5].GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        coloredWalls2[6].GetComponent<MeshRenderer>().material = coloredWalls[4].GetComponent<MeshRenderer>().material;
        RandomObject();
    }

    void Update()
    {
        matchcolor();
    }

    void matchcolor()
    {
        GameObject game2 = GameObject.Find("RandomColor/BookShelf/Cube(8)/Cube(8)/Cube (1)");
        game2.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
        GameObject game3 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Cube (2)");
        game3.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
        GameObject game = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Cube2");
        game.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;
        GameObject game4 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Cube3");
        game4.GetComponent<MeshRenderer>().material = coloredWalls[0].GetComponent<MeshRenderer>().material;

        GameObject game6 = GameObject.Find("RandomColor/BookShelf/Cube(8)/Cube(8)/Sphere");
        game6.GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
        GameObject game7 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Sphere");
        game7.GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
        GameObject game8 = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Sphere2");
        game8.GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;
        GameObject game9 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Sphere3");
        game9.GetComponent<MeshRenderer>().material = coloredWalls[1].GetComponent<MeshRenderer>().material;

        GameObject game10 = GameObject.Find("RandomColor/BookShelf/Cube(8)/Cube(8)/Capsule (1)");
        game10.GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        GameObject game11 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Capsule (2)");
        game11.GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        GameObject game12 = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Capsule2");
        game12.GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;
        GameObject game13 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Capsule3");
        game13.GetComponent<MeshRenderer>().material = coloredWalls[2].GetComponent<MeshRenderer>().material;

        GameObject game15 = GameObject.Find("RandomColor/BookShelf/Cube(8)/Cube(8)/Pyramid2 (1)/Pyramid_Thin_Base");
        game15.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        GameObject game16 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Pyramid2 (1)/Pyramid_Thin_Base");
        game16.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        GameObject game17 = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Pyramid2 (1)/Pyramid_Thin_Base");
        game17.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        GameObject game18 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Pyramid3/Pyramid_Thin_Base");
        game18.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;

        GameObject game20 = GameObject.Find("RandomColor/BookShelf/Cube(8)/Cube(8)/Pyramid2 (1)/Pyramid_Thin_Tip");
        game20.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        GameObject game21 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Pyramid2 (1)/Pyramid_Thin_Tip");
        game21.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        GameObject game22 = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Pyramid2 (1)/Pyramid_Thin_Tip");
        game22.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;
        GameObject game23 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Pyramid3/Pyramid_Thin_Tip");
        game23.GetComponent<MeshRenderer>().material = coloredWalls[3].GetComponent<MeshRenderer>().material;

        GameObject game24 = GameObject.Find("RandomColor/BookShelf/Cube(8)/Cube(8)/Pyramid (1)/Pyramid_Thin_Base");
        game24.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        GameObject game25 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Pyramid (2)/Pyramid_Thin_Base");
        game25.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        GameObject game26 = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Pyramid2/Pyramid_Thin_Base");
        game26.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        GameObject game27 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Pyramid (2)/Pyramid_Thin_Base");
        game27.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;

        GameObject game28 = GameObject.Find("RandomColor/BookShelf/Cube(8)/Cube(8)/Pyramid (1)/Pyramid_Thin_Tip");
        game28.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        GameObject game29 = GameObject.Find("RandomColor/BookShelf/Cube (9)/Cube (9)/Pyramid (2)/Pyramid_Thin_Tip");
        game29.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        GameObject game30 = GameObject.Find("RandomColor/BookShelf2/Cube (5)/Group1/Pyramid2/Pyramid_Thin_Tip");
        game30.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
        GameObject game31 = GameObject.Find("RandomColor/BookShelf2/Cube (8)/Group2/Pyramid (2)/Pyramid_Thin_Tip");
        game31.GetComponent<MeshRenderer>().material = coloredWalls[5].GetComponent<MeshRenderer>().material;
    }

    public void RandomObject()
    {
        foreach (GameObject wall in coloredWalls)
        {
            int newIndex = Random.Range(0, randomObject.Count);
            randomObject[newIndex].SetActive(false);
        }
    }
}