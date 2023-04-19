using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [Header("Cameras")]
    public GameObject mainCam;
    public GameObject firstPersonCam;
    public DragRotate rotator;

    [Header("Checkers")]
    public bool inFirstPerson;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SwitchCamera()
    {
        rotator.buttonPressed = true;
        if (!inFirstPerson)
        {
            mainCam.SetActive(false);
            firstPersonCam.SetActive(true);
            inFirstPerson = true;
        }
        else
        {
            mainCam.SetActive(true);
            firstPersonCam.SetActive(false);
            inFirstPerson = false;
        }
    }

    public void Unselect()
    {
        rotator.buttonPressed = false;
    }
}
