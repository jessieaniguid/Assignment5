using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Camera thirdPerson;
    public Camera firstPerson;

    //private void Update()
    //{
    //    if (Input.GetAxis("Horizontal") != 0)
    //    {
    //        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
    //    }

    //}

    public void switchCamera()
    {
        if (thirdPerson.isActiveAndEnabled)
        {
            firstPerson.enabled = true;
            thirdPerson.enabled = false;
        }else if (firstPerson.isActiveAndEnabled)
        {
            firstPerson.enabled = false;
            thirdPerson.enabled = true ;
        }
    }
}
