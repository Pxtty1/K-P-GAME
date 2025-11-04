using UnityEngine;

public class Player : MonoBehaviour
{

    public int speed;
    float inputx;
    public Rigidbody2D rb;
    public Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         inputx = Input.GetAxisRaw("Horizontal");

        if (inputx > 0)
            transform.localScale = new Vector3(10, 10, 10); // facing right
        else if (inputx < 0)
            transform.localScale = new Vector3(-10, 10, 10);

        if (Mathf.Abs(inputx) > 0)
            anim.Play("run-anim");   
        else
            anim.Play("idle-anim");
    }

    private void FixedUpdate()
    {
            rb.linearVelocity = new Vector2(inputx * speed, rb.linearVelocity.y);   
    }
}
