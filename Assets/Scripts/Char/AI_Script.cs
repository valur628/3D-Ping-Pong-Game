using UnityEngine;
using System.Collections;

public class AI_Script : MonoBehaviour
{

    public GameObject Ball;
    public float speed = 30;
    public float lerpSpeed = 1f;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Ball.transform.position.y > transform.position.y)
        {

            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.up * speed, lerpSpeed * Time.deltaTime);
        }
        else if (Ball.transform.position.y < transform.position.y)
        {

            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.down * speed, lerpSpeed * Time.deltaTime);
        }
        else
        {
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.zero * speed, lerpSpeed * Time.deltaTime);
        }

        if (Ball.transform.position.x > transform.position.x)
        {

            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.right * speed, lerpSpeed * Time.deltaTime);
        }
        else if (Ball.transform.position.x < transform.position.x)
        {

            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.left * speed, lerpSpeed * Time.deltaTime);
        }
        else
        {
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.zero * speed, lerpSpeed * Time.deltaTime);
        }
    }
}

/*
[Ai 실수하는 버전]
using UnityEngine;
using System.Collections;

public class AI_Script : MonoBehaviour
{

    public GameObject Ball;
    public float speed = 30;
    public float lerpSpeed = 1f;
    private Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Ball.transform.position.y > transform.position.y)
        {
            if (rigidBody.velocity.y < 0)
            {
                rigidBody.velocity = Vector3.zero;
            }
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.up * speed, lerpSpeed * Time.deltaTime);
        }
        else if (Ball.transform.position.y < transform.position.y)
        {
            if (rigidBody.velocity.y > 0)
            {
                rigidBody.velocity = Vector3.zero;
            }
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.down * speed, lerpSpeed * Time.deltaTime);
        }
        else
        {
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.zero * speed, lerpSpeed * Time.deltaTime);
        }

        if (Ball.transform.position.x > transform.position.x)
        {
            if (rigidBody.velocity.x < 0)
            {
                rigidBody.velocity = Vector3.zero;
            }
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.right * speed, lerpSpeed * Time.deltaTime);
        }
        else if (Ball.transform.position.x < transform.position.x)
        {
            if (rigidBody.velocity.x > 0)
            {
                rigidBody.velocity = Vector3.zero;
            }
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.left * speed, lerpSpeed * Time.deltaTime);
        }
        else
        {
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, Vector3.zero * speed, lerpSpeed * Time.deltaTime);
        }
    }
}
*/