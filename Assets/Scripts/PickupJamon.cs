using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupJamon : MonoBehaviour
{
    
    private int cJamon=0;
    public Text cJamonT;
    GameObject[] Jamon;
    public bool Done =false;
        public bool Skip =true;


    // Start is called before the first frame update
    void Start()
    {
        setCJamonT();
        Jamon = GameObject.FindGameObjectsWithTag("Jamon");
    }

  private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.CompareTag("Jamon")){
            collider.gameObject.SetActive (false);
            cJamon++;
            setCJamonT();
            Done=false;
        if(Jamon.Length == cJamon){
            Done=true;
        } 
        }
}

    public void setCJamonT(){
            cJamonT.text = "X "+ cJamon.ToString();
    }
    public int getCJamon(){
        return cJamon;
    }

 public void activateJamon() {
     if(Skip == false){
         for(int i = 0; i<=Jamon.Length-1;i++){
            Jamon[i].SetActive(true);
         }}
         else{
    cJamon=0;
    setCJamonT();
}    cJamon=0;
    setCJamonT();
}

public void activatePickupJamon(){
    activateJamon();
}
}
