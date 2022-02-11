using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainCharacterMovement : MonoBehaviour
{
    #region Fields
    [SerializeField] float horizontalSpeed;
    [SerializeField] float verticalSpeed;

    private Rigidbody2D rb;
    private Animator animator;

    private bool isGrounded;
    private bool isRight;


    #endregion



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontalSpeed * Input.GetAxis("Horizontal"), rb.velocity.y);
        if (Input.GetAxis("Horizontal") > 0)
        {
            animator.SetBool("isRunning", true);
            if (!isRight)
                transform.localScale = new Vector3(1, 1, 1);
            isRight = true;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("isRunning", true);
            if (isRight)
                transform.localScale = new Vector3(-1, 1, 1);
            isRight = false;
        }
        else
            animator.SetBool("isRunning", false);



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, verticalSpeed),ForceMode2D.Impulse);
            isGrounded = false;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        isGrounded = true;
    }
}
