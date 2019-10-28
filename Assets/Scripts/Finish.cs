using UnityEngine;

public class Finish : MonoBehaviour
{
    public Pickup pickup;
    public MovementOnPC MovementOnPC;
    public GameObject ScoreUI;
    public GameObject HealthUI;
  private void OnTriggerEnter(Collider collider) {
     // Debug.Log(collider.name);

        if (collider.tag == "Player" && pickup.Done){
            //Debug.Log("BOOOM!!!");
            MovementOnPC.enabled =false;
            ScoreUI.SetActive(false);
            HealthUI.SetActive(false);
            FindObjectOfType<GameManager>().NextLevel();
        }
   }
}

