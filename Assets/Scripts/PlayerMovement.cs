using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    float forwardForce = sceneManager.speed;
    //float forwardForce = 3000f;
    float sidewaysForce = 150f;

    float jumpForce = 20f;

    public bool canJump = true;

    


    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if ( Input.GetKey("d")) {
            rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("j") & canJump ) {
            rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
            canJump = false;
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().gameOver();
        }

        if (Input.GetKey("end"))
        {
            SceneManager.LoadScene("title");
        }
        
    }
}
