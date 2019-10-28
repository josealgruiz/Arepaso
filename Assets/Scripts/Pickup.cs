using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    
    private int cQueso=0;
    public Text cQuesoT;
    GameObject[] Queso;
    public bool Done =false;


    // Start is called before the first frame update
    void Start()
    {
        setCQuesoT();
        Queso = GameObject.FindGameObjectsWithTag("Queso");
    }

  private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.CompareTag("Queso")){
            collider.gameObject.SetActive (false);
            cQueso++;
            setCQuesoT();
            Done=false;
        if(Queso.Length == cQueso){
            Done=true;
        } 
        }
}

    public void setCQuesoT(){
            cQuesoT.text = "X "+ cQueso.ToString();
    }
    public int getCQueso(){
        return cQueso;
    }

 public void activateQueso() {
         for(int i = 0; i<=Queso.Length-1;i++){
            Queso[i].SetActive(true);
         }
    cQueso=0;
    setCQuesoT();
}

public void activatePickups(){
    activateQueso();
}
}
