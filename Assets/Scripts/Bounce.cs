using UnityEngine;

public class Bounce : MonoBehaviour
{

    public Rigidbody Player;
    public AudioSource sonido;
    private Vector3 forceadded ;
    public float speed = 100f;
    
    void Start(){
        sonido = GetComponent<AudioSource> ();
    }


  private void OnTriggerEnter(Collider collider) {

        if (collider.tag == "Player"){
            forceadded = Player.velocity;
            sonido.Play();
            Player.AddForce(-forceadded* speed * Time.deltaTime, ForceMode.VelocityChange);
        }
   }
}
