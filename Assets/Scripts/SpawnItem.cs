using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnItem : MonoBehaviour {

    public GameObject[] item;
    public Transform[] Player;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(item[0], Player[0].position, Quaternion.identity);
        Instantiate(item[1], Player[1].position, Quaternion.identity);
        Instantiate(item[2], Player[2].position, Quaternion.identity);
        Instantiate(item[3], Player[3].position, Quaternion.identity);
        Instantiate(item[4], Player[4].position, Quaternion.identity);
    }


}
