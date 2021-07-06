using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float x= 1;
    public int y = 1;
    float speed;
    Rigidbody2D rigidbody2D;
    public Vector3 rotationPoint;

    public enum MOVE_DIRECTION
    {
        STOP,
        LEFT,
        RIGHT,
    }
    MOVE_DIRECTION moveDirection = MOVE_DIRECTION.STOP; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (x == 0)
        {
            moveDirection = MOVE_DIRECTION.STOP;
        }
        else if (x > 0)
        {
            moveDirection = MOVE_DIRECTION.RIGHT;
        }
        else if ( x < 0)
        {
            moveDirection = MOVE_DIRECTION.LEFT;
        }
    }
    private void FixedUpdate()
    {
        switch (moveDirection)
        {
            case MOVE_DIRECTION.STOP:
                speed = 0 * y;
                break;

            case MOVE_DIRECTION.LEFT:
                speed = -1 * y;
                break;

            case MOVE_DIRECTION.RIGHT:
                speed = 1 * y;
                break;
        }
        rigidbody2D.velocity = new Vector2(speed,rigidbody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (x > 0)
        {
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 1, 0), 180);
            x = -1;
        }
        else if (x < 0)
        {
            transform.RotateAround(transform.TransformPoint(rotationPoint), new Vector3(0, 1, 0), -180);
            x = 1;
        }
    }
}
