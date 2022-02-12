using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private string SceneName;
    private string lastSceneName;

    private Vector2 moveDir;
    private Vector2 lastMoveDir;

    private bool leftRoom1;

    Rigidbody2D rb;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        StartingAnimationInScene();

        Debug.Log(lastSceneName);
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        Animate();
        PositionChecker();
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

    void StartingAnimationInScene()
    {
        if(SceneManager.GetActiveScene().name == "Room1")
        {
            lastMoveDir.y = 1;
        }
    }

    void PositionChecker()
    {
        if(SceneManager.GetActiveScene().name == "SampleScene" && lastSceneName == "Room1")
        {
            this.transform.position = new Vector3(-3.5f, -0.2f, 0);
        }

        Debug.Log("Position set");
    }
    
    public void EnterRoom()
    {
        SceneManager.LoadScene(SceneName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Room1 Tag"))
        {
            SceneName = "Room1";
            lastSceneName = "SampleScene";
        }

        else if (collision.gameObject.CompareTag("Room1 Leave"))
        {
            SceneName = "SampleScene";
            lastSceneName = "Room1";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Room1 Tag"))
        {
            SceneName = null;
        }
    }
}
