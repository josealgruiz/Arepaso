using UnityEngine;

public class Bounce : MonoBehaviour
{

    public Rigidbody Player;

    private Vector3 forceadded ;
    public float speed = 100f;
    
  private void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Player"){
            forceadded = Player.velocity;
            Player.AddForce(-forceadded* speed * Time.deltaTime, ForceMode.VelocityChange);
            
        }
   }
}
