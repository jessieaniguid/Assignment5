using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOneTrigger : MonoBehaviour
{
    public Camera firsRoomCamera;
    public OneAxisCamera oneAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(oneAxis.isActivated == false);
        Debug.Log(other.gameObject.name == "Player");
        if (other.gameObject.name == "Player" && oneAxis.isActivated != true)
        {
            Debug.Log("fooble");
            oneAxis.gameObject.SetActive(true);
            oneAxis.isActivated = true;
            
            firsRoomCamera.gameObject.SetActive(false);
        }
        else if(other.gameObject.name == "Player" && oneAxis.isActivated == true)
        {
            Debug.Log("goodle");
            oneAxis.gameObject.SetActive(false);
            oneAxis.isActivated = false;
            
            firsRoomCamera.gameObject.SetActive(true);
        }
    }
}
