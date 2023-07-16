using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.1f;

    public bool facingright = true;

    private Rigidbody2D rig;

    public Joystick joystick;

    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private void Start()
    {
       
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        moveVelocity = moveInput.normalized * speed;

        if (!facingright && moveInput.x > 0)
        {
            Flip();
        }
        else if (facingright && moveInput.x < 0)
        {
            Flip();
        }
    }
    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        facingright = !facingright;
        //Vector3 Scaler = transform.localScale;
        //Scaler.x *= -1;
        //transform.localScale = Scaler;
        transform.Rotate(0f, 180f, 0f);
    }


}
