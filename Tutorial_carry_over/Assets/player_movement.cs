using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float move_speed = 10.0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float forward = Input.GetAxis("Vertical") * move_speed;
        float strafing = Input.GetAxis("Horizontal") * move_speed;
        forward *= Time.deltaTime;
        strafing *= Time.deltaTime;

        transform.Translate(strafing, 0, forward);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        
    }
}
