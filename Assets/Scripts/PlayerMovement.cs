using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    private Animator animator;
    private bool TurningL = false;
    private bool TurningR = false;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") && !TurningR)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            animator.SetBool("TurningR", true);

            TurningR = true;
        }

        else if (Input.GetKey("d") && TurningR)
        {
            animator.SetBool("TurningR", false);

            TurningR = false;
        }

        if (Input.GetKey("a") && !TurningL)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            animator.SetBool("TurningL", true);

            TurningL = true;
        }

        else if (Input.GetKey("a") && TurningL)
        {
            animator.SetBool("TurningL", false);

            TurningL = false;
        }



        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}

