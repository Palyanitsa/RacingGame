using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    private Animator animator;
    private bool TurningL = false;
    private bool TurningR = false;
    public float topSpeed = 1000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Mathf.Lerp(rb.velocity.z, topSpeed, 0.1f));

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

