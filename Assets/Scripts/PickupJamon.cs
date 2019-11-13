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
    public AudioSource sonido;

    public GameObject ScoreUI;
    private int jamonl;

    void Start()
    {
        setCJamonT();
        Jamon = GameObject.FindGameObjectsWithTag("Jamon");
        jamonl = Jamon.Length;
        sonido = GetComponent<AudioSource> ();
    }

  private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.CompareTag("Jamon")){
            collider.gameObject.SetActive (false);
            sonido.Play();
            cJamon++;
            setCJamonT();
            Done=false;
          if(jamonl == cJamon){
            Done=true;
            ScoreUI.SetActive(false);
        }
        }
}

    public void setCJamonT(){
            cJamonT.text = "X "+ cJamon.ToString();
    }
    public int getCJamon(){
        return cJamon;
    }

}
