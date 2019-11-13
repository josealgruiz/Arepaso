using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupQueso : MonoBehaviour
{
    
    private int cQueso=0;
    public Text cQuesoT;
    GameObject[] Queso;
    public bool Done =false;
   // public bool Skip =true;
    public GameObject ScoreUI;
    private int quesol;
    public AudioSource sonido;

    // Start is called before the first frame update
    void Start()
    {
        setCQuesoT();
        Queso = GameObject.FindGameObjectsWithTag("Queso");
        quesol = Queso.Length;
        sonido = GetComponent<AudioSource> ();
    }

  private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.CompareTag("Queso")){
            collider.gameObject.SetActive (false);
            sonido.Play();
            cQueso++;
            setCQuesoT();
            Done=false;
        if(quesol == cQueso){
            Done=true;
            ScoreUI.SetActive(false);
        } 
        }
}

    public void setCQuesoT(){
            cQuesoT.text = "X "+ cQueso.ToString();
    }
    public int getCQueso(){
        return cQueso;
    }

}


























 /*public void activateQueso() {
     if(Skip == false){
         for(int i = 0; i<=Queso.Length-1;i++){
            Queso[i].SetActive(true);
         }}
         else{
    cQueso=0;
    setCQuesoT();
         }
    cQueso=0;
    setCQuesoT();
}

public void activatePickupQueso(){
    activateQueso();
}*/

