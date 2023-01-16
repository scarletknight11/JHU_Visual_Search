using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour {

    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerPrefabs;
    private InputDevice targetDevice;
    private GameObject spawnedController;
    public GameObject cross;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();

        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach(var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if(devices.Count> 0)
        {
            targetDevice = devices[0];
            //GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonvalue);  
        //if(primaryButtonvalue)
        //{
        //    cross.SetActive(false);
        //}

        if(OVRInput.Get(OVRInput.Button.One))
        {
            cross.SetActive(true);
        }
    }
}
