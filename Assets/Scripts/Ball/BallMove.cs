using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

    public float speed = 0f;
    public float ballpower = 5f;
    public bool ForceDriction = true;
    Rigidbody rigidball;

    void Awake ()
    {
        rigidball = GetComponent<Rigidbody>();
    }

	void Start ()
    {
    }
    void Update()
    {
        if (ForceDriction == false)
        {
            rigidball.AddForce(Vector3.back * ballpower, ForceMode.Acceleration);
        }
        else if (ForceDriction == true)
        {
            rigidball.AddForce(Vector3.forward * ballpower, ForceMode.Acceleration);
        }
    }

    void OnCollisionEnter(Collision BallPhyisc)
    {
        if (BallPhyisc.gameObject.name == "Player_1")
        {
            ForceDriction = false;
        }
        else if (BallPhyisc.gameObject.name == "Player_2")
        {
            ForceDriction = true;
        }
    }
}


/*
 * void Update ()
{
    rigidball.AddForce(Vector3.forward * ballpower, ForceMode.Acceleration);
   // transform.Translate(Vector3.forward * speed * Time.deltaTime);
}
    void OnCollisionEnter(Collision BallPhyisc)
{
    if (BallPhyisc.gameObject.tag == "Player")
    {
        rigidball.AddForce(Vector3.forward * ballpower, ForceMode.Acceleration);
    }
}
}
*/
