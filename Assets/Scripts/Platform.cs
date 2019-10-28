using UnityEngine;

public class Platform : MonoBehaviour
{

    public Rigidbody Player;

    public float h=25f;

   private void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Player"){
            
            Player.AddForce(0,h,0, ForceMode.Impulse);
            
        }
   }
   
}
