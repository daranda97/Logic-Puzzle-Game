using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps_cam_look : MonoBehaviour
{
    // Start is called before the first frame update

    /* camera control method 1
    Vector2 rotation = Vector2.zero;
    public float speed = 3;
    //*/

    //*  camera control method 2
    Vector2 mouse_look;
    Vector2 Smoothing;
    public float mouse_sensitivity = 5f;
    public float smoothing_factor = 2f;
    //*/


    GameObject character;


    void Start()
    {
        character = this.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {


        /*
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;
        //*/


        var target = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        target = Vector2.Scale(target,new Vector2(mouse_sensitivity * smoothing_factor, mouse_sensitivity * smoothing_factor));
        Smoothing.x = Mathf.Lerp(Smoothing.x, target.x, 1f / smoothing_factor);
        Smoothing.y = Mathf.Lerp(Smoothing.y, target.y, 1f / smoothing_factor);
        mouse_look += Smoothing;
        mouse_look.y = Mathf.Clamp(mouse_look.y, -90f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-mouse_look.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouse_look.x, character.transform.up);
       



    }
}
