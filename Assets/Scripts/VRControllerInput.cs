using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using Unity.VisualScripting;

public class VRControllerInput : MonoBehaviour {

    //public XRController rightHand;
    //public InputHelpers.Button button;
     public GameObject cross;

    private InputDevice targetDevice;

    void Start()
    {

        List<InputDevice> devices = new List<InputDevice>();
        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

    }

    // Update is called once per frame
    void Update()
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if (primaryButtonValue == true)
        {
            cross.SetActive(false);
        }

        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if (triggerValue > 0.1f)
        {
            cross.SetActive(false);
        }
        //bool pressed;
       // rightHand.inputDevice.IsPressed(button, out pressed);

        //if (pressed)
        //{
            //cross.SetActive(false);
        ///}

    }
}
