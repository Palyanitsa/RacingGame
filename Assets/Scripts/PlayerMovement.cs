using UnityEngine;
using UnityEngine.iOS;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    private Animator animator;
    public float topSpeed = 1000f;
    public float sidewaysForce = 500f;

    public AudioSource aSourse;
    //public AudioClip TurnLR;    

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        //aSourse = GetComponent<AudioSource>();
    }

   
    void FixedUpdate ()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Mathf.Lerp(rb.velocity.z, topSpeed, 0.1f));

        //if (Input.GetKeyDown("d") || Input.GetKeyDown("a"))
        if (Input.GetKeyDown("a") || Input.GetKeyDown("d") || Input.touchCount > 0)
        {
            //aSourse.PlayOneShot(TurnLR);
        }

        if (Input.touchCount > 0)
        {
            //if (Input.GetKey("d"))
            //if (Input.GetButtonDown("TurnR"))
            if (Input.GetTouch(0).position.x > Screen.width / 2)
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                animator.SetBool("TurningR", true);
            }

            else
            {
                animator.SetBool("TurningR", false);
            }

            //if (Input.GetKey("a"))
            //if (Input.GetButtonDown("TurnL"))
            if (Input.GetTouch(0).position.x < Screen.width / 2)
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                animator.SetBool("TurningL", true);
            }

            else
            {
                animator.SetBool("TurningL", false);
            }
        }

        else 
        {
            //if (Input.GetKey("d"))
            //if (Input.GetButtonDown("TurnR"))
            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                animator.SetBool("TurningR", true);            
            }

            else
            {
            animator.SetBool("TurningR", false);
            }

            //if (Input.GetKey("a"))
            //if (Input.GetButtonDown("TurnL"))
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

                animator.SetBool("TurningL", true);
            }

            else 
            {
                animator.SetBool("TurningL", false);
            }
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

