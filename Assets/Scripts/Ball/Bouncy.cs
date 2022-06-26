using UnityEngine;
using System.Collections;

public class Bouncy : MonoBehaviour
{
    private float Move_x;
    private float Move_y;
    private float Move_z;

    public float F_Speed = 1.0f;
    public float N_Speed = 1.0f;
    public float Ball_acceler = 1.1f;

    private AudioSource BallBounceSource;
    public AudioClip BallBounceSound;

    void Start ()
    {
        N_Speed = F_Speed;
        Move_x = Random.Range(0, 2) == 0 ? -1 : 1;
        Move_y = Random.Range(0, 2) == 0 ? -1 : 1;
        Move_z = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(5, 10) * Move_x, Random.Range(5, 10) * Move_y, Random.Range(10, 25) * Move_z * N_Speed);

        BallBounceSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision Balls)
    {
        if (Balls.gameObject.tag == "Player")
        {
            BallBounceSource.clip = BallBounceSound;
            BallBounceSource.volume = 0.75f;
            BallBounceSource.Play();
            Move_x = Random.Range(0, 2) == 0 ? -1 : 1;
            Move_y = Random.Range(0, 2) == 0 ? -1 : 1;
            Move_z = Random.Range(0, 2) == 0 ? -1 : 1;

            N_Speed *= Ball_acceler;
            GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(5, 10) * Move_x, Random.Range(5, 10) * Move_y, Random.Range(10, 25) * Move_z * N_Speed);
        }
        if (Balls.gameObject.tag == "Score")
        {
            N_Speed = F_Speed;
            GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(5, 10) * Move_x, Random.Range(5, 10) * Move_y, Random.Range(10, 25) * Move_z * N_Speed);
        }
    }
}
