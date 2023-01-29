using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;

    bool gameHasEnded = false;

    public GameObject completeLevelUI;

     public void completeLevel ()
     {
        //Debug.Log("Level Complete");
        completeLevelUI.SetActive(true);
     }


    public void gameOver()
   {
        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            Invoke("restart", restartDelay);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
