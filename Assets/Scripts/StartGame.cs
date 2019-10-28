using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartGame : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("o")){
            Estart();
        }
        
    }

    public void Estart(){
        FindObjectOfType<GameManager>().StartGame();
    }
}
