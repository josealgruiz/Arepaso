using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
    
    private int cQueso=0;
    public Text cQuesoT;
    // Start is called before the first frame update
    void Start()
    {
        setCQuesoT();
    }

  private void OnTriggerEnter(Collider collider) {

        if (collider.gameObject.CompareTag("Queso")){
            collider.gameObject.SetActive (false);
            cQueso++;
            setCQuesoT();
            
        }
}

    public void setCQuesoT(){
            cQuesoT.text = "Queso: "+ cQueso.ToString();
    }
}
