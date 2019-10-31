using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
        
   //public Life life = new Life();
  
  public int health;
    public GameObject ScoreUI;
    public GameObject Heart1, Heart2, Heart3, gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
        switch(health){
            case 3:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
            break;
            case 2:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(false);
            break;
            case 1:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
            break;
            case 0:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                ScoreUI.SetActive(false);
            break;
        }

    }


}
/* 
public class Life{
        public int health;

        public int Health{
            get{
                return health;
            }
            set{
                    health=value;
            }
        }
public int getHealth(){
    return this.health;
}

public void setHealth(int h){
    this.health = h;
}

public int getCurrHealth(int count){
    return 3-count;
}
}
*/
