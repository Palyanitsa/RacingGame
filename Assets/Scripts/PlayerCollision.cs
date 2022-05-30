using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    private Animator animator;

    public AudioSource aSourse;
    public AudioClip Crash;

    void Start()
    {
        animator = GetComponent<Animator>();
        aSourse = GetComponent<AudioSource>();
    }

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

            playSingleSound(Crash);
        }
    }

    void playSingleSound(AudioClip clip, float volume = 1.0f)
    {
        aSourse.clip = clip;

        aSourse.volume = volume;

        aSourse.Play();
    }

}
