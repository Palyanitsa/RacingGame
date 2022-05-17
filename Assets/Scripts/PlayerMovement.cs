using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    private Animator animator;
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

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            animator.SetBool("TurningR", true);
        }

        else
        {
            animator.SetBool("TurningR", false);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            animator.SetBool("TurningL", true);
        }

        else 
        {
            animator.SetBool("TurningL", false);
        }



        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}

