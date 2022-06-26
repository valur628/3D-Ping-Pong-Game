using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_2Move : MonoBehaviour
{
    public float PlayerMoveSpeed = 5.0f; //플레이어 속도
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            gameObject.transform.Translate(new Vector3(-PlayerMoveSpeed / 100, 0, 0));

        if (Input.GetKey(KeyCode.LeftArrow))
            gameObject.transform.Translate(new Vector3(PlayerMoveSpeed / 100, 0, 0));

        if (Input.GetKey(KeyCode.UpArrow))
            gameObject.transform.Translate(new Vector3(0, PlayerMoveSpeed / 100, 0));

        if (Input.GetKey(KeyCode.DownArrow))
            gameObject.transform.Translate(new Vector3(0, -PlayerMoveSpeed / 100, 0));

    }
}
