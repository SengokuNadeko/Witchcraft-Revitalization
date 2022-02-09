using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Vector2 moveDir;
    private Vector2 lastMoveDir;
    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        Animate();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Inputs()
    {
        
        if ((Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0) && moveDir.x != 0 || moveDir.y != 0)
        {
            lastMoveDir = moveDir;
        }

        moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * speed, moveDir.y * speed);
    }

    void Animate()
    {
        anim.SetFloat("AnimMoveX", moveDir.x);
        anim.SetFloat("AnimMoveY", moveDir.y);
        anim.SetFloat("AnimMoveMagnitude", moveDir.magnitude);
        anim.SetFloat("AnimLastMoveX", lastMoveDir.x);
        anim.SetFloat("AnimLastMoveY", lastMoveDir.y);
    }
}
