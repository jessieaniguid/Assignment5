using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTwoTrigger : MonoBehaviour
{

    public cameraLookAt cam;
    public Camera secondRoomCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(cam.isActivated == false);
        Debug.Log(other.gameObject.name == "Player");
        if (other.gameObject.name == "Player" && cam.isActivated != true)
        {
            Debug.Log("fooble");
            cam.gameObject.SetActive(true);
            cam.isActivated = true;

            secondRoomCamera.gameObject.SetActive(false);
        }
        else if (other.gameObject.name == "Player" && cam.isActivated == true)
        {
            Debug.Log("goodle");
            cam.gameObject.SetActive(false);
            cam.isActivated = false;

            secondRoomCamera.gameObject.SetActive(true);
        }
    }
}
