
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().gameOver();
        }

        if (collisionInfo.collider.tag == "Ground")
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().canJump = true;
        }
    }
}
