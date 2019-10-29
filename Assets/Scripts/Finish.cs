using UnityEngine;

public class Finish : MonoBehaviour
{
    public PickupQueso PickupQueso;
    public PickupJamon PickupJamon;
    public MovementOnPC MovementOnPC;
    public GameObject ScoreUI;
    public GameObject HealthUI;
    private bool queso = false;
    private bool quesoCheck = false;
        private bool jamon = false;
    private bool jamonCheck = false;
  private void OnTriggerEnter(Collider collider) {
     // Debug.Log(collider.name);
        if(collider.tag == "Player" ){ 
            quesoCheck = PickupQuesoActive();
            jamonCheck = PickupJamonActive();
            if(quesoCheck == PickupQueso.Done){
                queso = true;
            }else {
                queso = false;
            }
            if(jamonCheck == PickupJamon.Done){
                jamon = true;
            }else {
                jamon = false;
            }
            }

        if (collider.tag == "Player" && queso && jamon){
            //Debug.Log("BOOOM!!!");
            MovementOnPC.enabled =false;
            ScoreUI.SetActive(false);
            HealthUI.SetActive(false);
            FindObjectOfType<GameManager>().NextLevel();
        }
   }

   public bool PickupQuesoActive (){
       if(PickupQueso.isActiveAndEnabled.Equals(true)){
           return true;
       } else {
          return false;
       }
   }
      public bool PickupJamonActive (){
       if(PickupJamon.isActiveAndEnabled.Equals(true)){
           return true;
       } else {
            return false;
       }
   }
}

