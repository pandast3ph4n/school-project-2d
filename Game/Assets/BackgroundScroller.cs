using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{ 
    public BoxCollider2D collider;
    public Rigidbody2D rg;

    private float width;
    private float scrollSpeed = -3f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rg = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        rg.velocity = new Vector2(scrollSpeed, 0);
        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
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

