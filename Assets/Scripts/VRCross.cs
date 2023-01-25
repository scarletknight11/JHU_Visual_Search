using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class VRCross : MonoBehaviour {

    public InputActionReference input = null;
    public GameObject cross;

    private void Update()
    {
        float value = input.action.ReadValue<float>();
        UpdateObjects();
    }

    private void UpdateObjects()
    {
        cross.SetActive(false);
    }
}
