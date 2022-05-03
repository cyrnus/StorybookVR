using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class OurHand : MonoBehaviour
{

    // public value to set in Unity, private used only in script
    public GameObject ourHandPrefab;
    public InputDeviceCharacteristics ourcontrollerCharacteristics;

    private InputDevice ourDevice;

    // Start is called before the first frame update
    void Start()
    {
        InitializeOurHand();
    }

    void InitializeOurHand()
    {
        //check for our controller characteristics
        List<InputDevice> devices = new List<InputDevice>();
        //InputDevices.GetDevicesWithCharacteristics(ourcontrollerCharacteristics, devices);
        InputDevices.GetDevices(devices);
        Debug.Log("found " + devices.Count + "devices");

        //If Device identified, Instantiate a Hand
        if (devices.Count > 0)
        {
            ourDevice = devices[0];

        }
            GameObject newHand = Instantiate(ourHandPrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
