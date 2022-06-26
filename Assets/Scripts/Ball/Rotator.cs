using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	void Update ()
    {
        transform.Rotate(new Vector3(30, 90, 60) * Time.deltaTime);
	}
}
