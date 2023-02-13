using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;

public class RandomColor : MonoBehaviour {
    
    private float rColor;
    private float gColor;
    private float bColor;
    public GameObject obj;


    // Start is called before the first frame update
    void Start()
    {
        var cubeRenderer = obj.GetComponent<Renderer>();
        Color background = new Color(Random.Range(0, 255),Random.Range(0, 255),Random.Range(0, 255),255);
        cubeRenderer.material.color = background;
        Debug.Log("RGB: " + background);
    }

}
