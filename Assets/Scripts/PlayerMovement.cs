using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    private Animator animator;
    public float topSpeed = 1000f;
    public float sidewaysForce = 500f;

    public AudioSource aSourse;
    public AudioClip TurnLR;    

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        aSourse = GetComponent<AudioSource>();
    }

    private void Update()
    {

        //if (Input.GetKeyDown("d") || Input.GetKeyDown("a"))
        if (Input.GetButtonDown("TurnR") || Input.GetButtonDown("TurnL"))
        {
            aSourse.PlayOneShot(TurnLR);
        }
    }

    void FixedUpdate ()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Mathf.Lerp(rb.velocity.z, topSpeed, 0.1f));



        //if (Input.GetKey("d"))
        if (Input.GetButtonDown("TurnR"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            animator.SetBool("TurningR", true);
        }

        else
        {
            animator.SetBool("TurningR", false);
        }

        //if (Input.GetKey("a"))
        if (Input.GetButtonDown("TurnL"))
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
    void playSingleSound(AudioClip clip, float volume = 1.0f)
    {
        aSourse.clip = clip;

        aSourse.volume = volume;

        aSourse.Play();
    }
}

