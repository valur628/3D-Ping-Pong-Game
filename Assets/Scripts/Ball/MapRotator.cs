using UnityEngine;
using System.Collections;

public class MapRotator : MonoBehaviour
{
	void Update()
    {
        transform.Rotate(new Vector3(0, 0, 150) * Time.deltaTime);
    }
}
