using UnityEngine;

public class MovementOnPC : MonoBehaviour
{
  //public Rigidbody rb; se usa para referenciar rigidbody componente del objeto usado, recordar arrastrarlo en unity
    public Rigidbody rb;
    public float movementForce = 100f;
    private Vector3 vec = new Vector3(0f, 1.5f, 0f); 



    // Update is called once per frame
    //cuando usas las fisicas de unity es recomendable usar FixedUpdate en vex de Update
    void FixedUpdate()
    {
        //AddForce se usa para impulsarle alguna fuerza a el objeto usando rb, Multiplicar * Time.deltaTime para que los fps no alteren el juego 
        
        if( Input.GetKey("d") ){
            rb.AddForce(movementForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
         if( Input.GetKey("w") ){
            rb.AddForce(0, 0 ,  movementForce * Time.deltaTime, ForceMode.VelocityChange);
        }
         if( Input.GetKey("s") ){
            rb.AddForce( 0 , 0 , -movementForce * Time.deltaTime , ForceMode.VelocityChange);
        }

         if( Input.GetKey("a") ){
            rb.AddForce(-movementForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }

          
    }

   
}

