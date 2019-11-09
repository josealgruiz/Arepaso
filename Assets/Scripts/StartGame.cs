using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartGame : MonoBehaviour
{
  
    void Update()
    {
        if(Input.GetKey("o")){
            Estart();
        }
        
    }

    public void Estart(){
                PlayerPrefs.SetInt("health",3);
        FindObjectOfType<GameManager>().StartGame();
    }
}
