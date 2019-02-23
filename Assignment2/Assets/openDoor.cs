using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public GameObject door;
    public ParticleSystem blast;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        door.GetComponent<Animator>().SetBool("open", true);
        blast.Play();
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (blast.isEmitting == false) GameObject.Destroy(this.gameObject);
    }
}
