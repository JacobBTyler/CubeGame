using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
   public void startGame()
   {
      sceneManager.speed = GameObject.Find("speed").GetComponent<sliderToText>().theSlider.value;
      Debug.Log(sceneManager.speed);
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

   }
   
}
