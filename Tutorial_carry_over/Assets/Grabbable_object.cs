using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable_object : MonoBehaviour
{


    private bool holding_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        this.GetComponent<Rigidbody>().useGravity = false;
        this.GetComponent<Rigidbody>().isKinematic = true;
        this.transform.SetParent(Camera.main.gameObject.transform);
        

    }
    private void OnMouseUp()
    {
        this.GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
        this.transform.parent = null;


    }
    
    
}
