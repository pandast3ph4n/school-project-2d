using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Controller : MonoBehaviour
{
    public float JumpForce;

    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D RB;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (isGrounded == false)
            {
                RB.AddForce(Vector2.down * JumpForce);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;

        }  

        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DeathScreen");
        }
    
    }


}
