using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARKit;


public class LightAmbience : MonoBehaviour
{
    private Light l;

    void Start()
    {
        l = GetComponent<Light>();
       // ARSubsystemManager.cameraFrameReceived += OnCameraFrameReceived;
    }

    void OnCameraFrameReceived(ARCameraFrameEventArgs eventArgs)
    {
        l.intensity = eventArgs.lightEstimation.averageBrightness.Value;
        l.colorTemperature = eventArgs.lightEstimation.averageColorTemperature.Value;
    }

    void OnDisable()
    {
       // ARSubsystemManager.cameraFrameReceived -= OnCameraFrameReceived;
    }
}


