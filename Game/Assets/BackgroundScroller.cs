using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{ 
    public BoxCollider2D collider;
    public Rigidbody2D rg;

    private float width;

    // Player score script as a variable
    [SerializeField] private ScoreScript scoreScript;
    public float scrollSpeed = 2f;
    private float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rg = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        // Gets player score and clamps it between 1 and infinity then multiplies by -1 (the score negative)
        speed = (scoreScript.ScoreNum + scrollSpeed) * -1;
        // Moves background
        rg.velocity = new Vector2(speed, 0);
        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        // Gets player score and clamps it between 1 and infinity then multiplies by -1
        speed = (scoreScript.ScoreNum + scrollSpeed) * -1;
        // Moves background
        rg.velocity = new Vector2(speed, 0);
        
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 3f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            ResetObstacle();
        }
    }

    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(Random.Range(-1, 3), Random.Range(-2, -2), 0); 
        transform.GetChild(1).localPosition = new Vector3(-3, -3, 0); 
        transform.GetChild(2).localPosition = new Vector3(5, -3, 0); 
    }

}

