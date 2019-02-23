using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{

    public Animator animator;
    public Rigidbody myrb;
    public Light myLight;


    //change how input affects physics
    public bool isFlying;
    public bool isGrounded;
    public float speed;
    public float flyingSpeed;
    public float jumpHeight;
    
    

    // Start is called before the first frame update
    void Start()
    {
        isFlying = false;
        myrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && myLight.isActiveAndEnabled == false)
        {
            myLight.gameObject.SetActive(true);
        }else if(Input.GetMouseButtonDown(0) && myLight.isActiveAndEnabled == true)
        {
            myLight.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
            myrb.AddRelativeForce(Vector3.up*jumpHeight);
        }

        if (isFlying == false && Input.GetKeyDown(KeyCode.F))
        {
            isFlying = true;
        }else if (isFlying == true && Input.GetKeyDown(KeyCode.F))
        {
            isFlying = false;
        }
        //rotates object
        //use this for flying
        if (isFlying)
        {
            myrb.isKinematic = true;
            transform.position += flyingSpeed * Time.deltaTime * transform.forward;
            transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
        }
        else
        {
            if(Input.GetAxis("Horizontal") > 0) {
                animator.SetFloat("Speed", Input.GetAxis("Horizontal"));
            }else if(Input.GetAxis("Horizontal") < 0)
            {
                animator.SetFloat("Speed", -Input.GetAxis("Horizontal"));
            }

            if (Input.GetAxis("Vertical") > 0)
            {
                animator.SetFloat("Speed", Input.GetAxis("Vertical"));
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                animator.SetFloat("Speed", Input.GetAxis("Vertical"));
            }

            animator.SetFloat("Direction", Input.GetAxis("Horizontal"));

            myrb.AddRelativeForce(new Vector3(Input.GetAxis("Horizontal") * speed, myrb.velocity.y, Input.GetAxis("Vertical") * speed));
            
            
 
        }



    }
}
