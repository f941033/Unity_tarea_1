using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "item")
        {
            Debug.Log("tocando item");

            if (Input.GetMouseButton(0))
            {
                other.transform.parent = transform;
                //other.transform.forward = transform.forward;
                other.transform.position = transform.position;
                other.GetComponent<Rigidbody>().useGravity = false;
                Debug.Log("cogiendo item");
            }
            else
            {
                other.transform.parent = null;                
                other.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
