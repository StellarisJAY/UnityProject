using System;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    public GameObject firstPersonCam;
    public GameObject thirdPersonCam;
    public GameObject currentCam;
    public void Start()
    {
        firstPersonCam = GameObject.Find("FirstPersonCam");
        thirdPersonCam = GameObject.Find("ThirdPersonCam");
        currentCam = thirdPersonCam;
    }
    
    public void Update()
    {
    
    }
    
    private void SwitchCamera()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            if(currentCam == firstPerosonCam)
            {
                
            }
            else
            {
            
            }
        }
    }
}
