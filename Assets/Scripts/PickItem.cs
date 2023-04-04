using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour {

    public GameObject[] itemToPickFrom;
    public Transform[] Player;

    // Start is called before the first frame update
    void Start()
    {
        Pick();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, itemToPickFrom.Length);
        int randomPositionIndex = Random.Range(0, Player.Length);
        int randomIndex2 = Random.Range(0, itemToPickFrom.Length);
        int randomPositionIndex2 = Random.Range(0, Player.Length);

        GameObject clone = Instantiate(itemToPickFrom[randomIndex], Player[randomPositionIndex].position, Quaternion.identity);
        GameObject clone2 = Instantiate(itemToPickFrom[randomIndex2], Player[randomPositionIndex2].position, Quaternion.identity);

        //if (itemToPickFrom[])
        //{

        //}

    }

}
