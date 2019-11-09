using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    float timeleft;
    //public GameObject timesup;
    // Start is called before the first frame update
    void Start()
    {
        //timespu.SetActive(false);
        timerBar = GetComponent<Image>();
        timeleft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft>0){
            timeleft -= Time.deltaTime;
            timerBar.fillAmount = timeleft/maxTime;
        }else{
            FindObjectOfType<GameManager>().RestartGame();
        }
        
    }
}
