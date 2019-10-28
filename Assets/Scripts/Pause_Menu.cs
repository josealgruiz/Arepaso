using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject PauseMenuUI;

    public MovementOnPhone movementOnPhone;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("p")){

            if(isGamePaused){
                Resume();
            }else{
                Pause();
            }

        }

    }

        public void Resume(){
            movementOnPhone.resetBase();
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            isGamePaused = false;
        }

        public void Pause(){
            //poner el menu de pausa en activo
            PauseMenuUI.SetActive(true);
            //para pausar le juego o tambien se puede usar para agregar algun efecto cambiando la velocidad
            Time.timeScale = 0f;
            isGamePaused = true; 
        }



    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu"); 
    }


}
