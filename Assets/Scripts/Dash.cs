using UnityEngine;

public class Dash : MonoBehaviour
{

    public Rigidbody Player;

    private float forceaddedX ;
    private float forceaddedZ ;

    private Vector3 forceadded;
    public float speed = 50f;
    
  private void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Player"){
            forceaddedX = Player.velocity.x;
            forceaddedZ = Player.velocity.z;
            
            Player.AddForce(forceaddedX* speed * Time.deltaTime,0,forceaddedZ* speed * Time.deltaTime, ForceMode.Impulse);
            
        }
   }
}
