using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOnPhone : MonoBehaviour
{  
    public Pickup pickup;
    public HealthSystem healthSystem;
    public GameObject mainCamera;
    private Rigidbody rb;
    public float speed = 40f;
    private Vector3 baseAcceleration;
    private Vector3 baseAcceleration1;
    private float returnspeed = 4f;
    //public bool isFlat = true;
        // Start is called before the first frame update
        private Vector3 vec = new Vector3(0f, 1.5f, 0f); 
        private Vector3 nul = new Vector3(0f, 0f, 0f);
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        resetBase();
        baseAcceleration1 = baseAcceleration;
    }

    // Update is called once per frame * Time.deltaTime , ForceMode.VelocityChange
    void FixedUpdate()
    {
        Vector3 fromCameraToMe = transform.position - mainCamera.transform.position;
         fromCameraToMe.y = 0;
         fromCameraToMe.Normalize(); 
        float moveH;
        float moveV;
        if(baseAcceleration1 != baseAcceleration){
            baseAcceleration1 = baseAcceleration;
            moveH = Input.acceleration.x-baseAcceleration1.x;
            moveV = Input.acceleration.y-baseAcceleration1.y; 
            returnspeed = 7f;
        }else {
            moveH = Input.acceleration.x-baseAcceleration1.x;
            moveV = Input.acceleration.y-baseAcceleration1.y; 
        }
 

        if(moveV <= -4f){
             moveV = Input.acceleration.y-baseAcceleration.y*returnspeed;
        }


         Vector3 movement = (fromCameraToMe * moveV + mainCamera.transform.right * moveH)* speed;
                            
             //Vector3 movement = new Vector3 (moveH, 0.0f, moveV);
             rb.AddForce(movement * Time.deltaTime, ForceMode.VelocityChange);


            //si el jugador se cae resetea el nivel
                if (rb.position.y <= -1 ){
                rb.transform.position = (vec);
                healthSystem.health -=1;
                movement = nul;
                pickup.activatePickups();
        }
    }

    void Restart(){
        rb.transform.position = (vec);
    }

    public void resetBase(){
        baseAcceleration = Input.acceleration;
    }
}



