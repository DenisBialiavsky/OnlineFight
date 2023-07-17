using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Unity.VisualScripting;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.1f;

    private float X, Y;
        
    public bool facingright = true;

    private Rigidbody2D rig;

    private Joystick joystick;

    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private PhotonView view;

    [SerializeField] private TextMeshProUGUI textName;

    private void Start()
    {
       
        rig = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
        joystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<Joystick>();
        textName.text = view.Owner.NickName;

    }

    private void Update()
    {
        X = joystick.Horizontal * speed;
        Y = joystick.Vertical * speed;

        if (!view.IsMine) return;
            //rig.velocity = new Vector2(X, Y);
            rig.velocity = new Vector2(joystick.Horizontal * speed, rig.velocity.y);

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
        if (view.IsMine)
        {
            rig.MovePosition(rig.position + moveVelocity * Time.fixedDeltaTime);
        }
    }

    private void Flip()
    {
        
        facingright = !facingright;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
       
        

    }


}
