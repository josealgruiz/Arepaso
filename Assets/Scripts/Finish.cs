using UnityEngine;

public class Finish : MonoBehaviour
{
    public MovementOnPC MovementOnPC;
  private void OnTriggerEnter(Collider collider) {
     // Debug.Log(collider.name);

        if (collider.tag == "Player"){
            //Debug.Log("BOOOM!!!");
            MovementOnPC.enabled =false;
            FindObjectOfType<GameManager>().NextLevel();
        }
   }
}

