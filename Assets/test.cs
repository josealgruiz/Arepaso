 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class test : MonoBehaviour
{
 
    public float moveSpeed = 5.0f;
    public float turnSpeed = 50.0f;
 
    Rigidbody rb;
    public float jumpStrength = 3.0f;
 
    void Start ()
    {
        rb = GetComponent<Rigidbody> (); // get the RIGIDBODY
    }
 
    void Update ()
    {
 
        float w_Input = Input.GetAxis ("Vertical") * moveSpeed; //WS or UP/Down
        w_Input *= Time.deltaTime;
        float rotation = Input.GetAxis ("Horizontal") * turnSpeed;// AD or L/Right
        rotation *= Time.deltaTime;
 
        transform.Translate (0, 0, w_Input);
        transform.Rotate (0, rotation, 0);
 
        if (Input.GetKeyDown ("space")) {
            rb.velocity = new Vector3 (0, jumpStrength, 0);
        } //END IF
 
    }
    // End Update
}
  //EOC