using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movespeed = 3f;
    public Transform leftwayPoint, RightWayPoint;
    Vector3 localScale;
    bool movingRight = true;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        leftwayPoint = GameObject.Find("leftWayPoint").GetComponent<Transform>();
        RightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > RightWayPoint.position.x)
            movingRight = false;
        if (transform.position.x < leftwayPoint.position.x)
            movingRight = true;

        if (movingRight)
            moveRight();
        else
            moveLeft();
    }

    void moveRight()
    {
        movingRight = true;
        localScale.x = 1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * movespeed, rb.velocity.y);
    }
    void moveLeft()
    {
        movingRight = false;
        localScale.x = -1;
        transform.localScale = localScale;
        rb.velocity = new Vector2(localScale.x * movespeed, rb.velocity.y);
    }

}
