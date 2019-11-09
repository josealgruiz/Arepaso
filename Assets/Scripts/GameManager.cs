using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;
    public float EndGameDelay = 2f;

    public GameObject CompleteLevelUI;

    public void RestartGame (){
        if (GameHasEnded == false){
        GameHasEnded = true;
        int health= PlayerPrefs.GetInt("health");
        PlayerPrefs.SetInt("health", health-1);
        Invoke("Restart", EndGameDelay); 
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void NextLevel(){
        Time.timeScale = 1f;
        CompleteLevelUI.SetActive(true);
    }

    public void StartGame(){
        SceneManager.LoadScene("0");
    }


}
