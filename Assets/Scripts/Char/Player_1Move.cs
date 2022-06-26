using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_1Move : MonoBehaviour
{
    public float PlayerMoveSpeed = 5.0f; //플레이어 속도
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            gameObject.transform.Translate(new Vector3(-PlayerMoveSpeed / 100, 0, 0));

        if (Input.GetKey(KeyCode.D))
            gameObject.transform.Translate(new Vector3(PlayerMoveSpeed / 100, 0, 0));

        if (Input.GetKey(KeyCode.W))
            gameObject.transform.Translate(new Vector3(0, PlayerMoveSpeed / 100, 0));

        if (Input.GetKey(KeyCode.S))
            gameObject.transform.Translate(new Vector3(0, -PlayerMoveSpeed / 100, 0));
    }
}
