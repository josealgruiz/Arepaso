using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float EndGameDelay = 2f;

    public GameObject CompleteLevelUI;

    public void RestartGame (){
        if (GameHasEnded == false){
        Debug.Log("Still have lives left!!");
        GameHasEnded = true;
        Invoke("Restart", EndGameDelay); 
        //FindObjectOfType<Health>().dead();
        //FindObjectOfType<Health>().health = FindObjectOfType<Health>().health-1;
        }
    }

    void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void NextLevel(){
        Debug.Log("Next Level");
        CompleteLevelUI.SetActive(true);
    }

    public void StartGame(){
        SceneManager.LoadScene("0");
    }
}
