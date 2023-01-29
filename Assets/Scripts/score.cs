using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        scoreText.SetText(player.position.z.ToString("0"));
    }
}
