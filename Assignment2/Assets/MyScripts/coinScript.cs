using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coinScript : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        int counter = int.Parse(text.text) + 1;
        text.text = counter.ToString();
        GameObject.Destroy(this.gameObject);
    }


}
