using UnityEngine;
using System.Collections;

public class FieldOfViewControl : MonoBehaviour {

    public Transform angleControl;
    public bool ControlCheck;

    public Transform MyPlayer;
    public Quaternion MyPosition;

    public KeyCode FOVChangeKey;

    void Start ()
    {
        ControlCheck = false;
    }

    void Update()
    {
        if(ControlCheck)
        {
            ControlLookAt();
        }
        else if(ControlCheck == false)
        {
            gameObject.transform.rotation = MyPosition;
        }
        if (Input.GetKeyDown(FOVChangeKey))
        {
            ControlCheck = !ControlCheck;
        }
    }
    void ControlLookAt()
    {
            transform.LookAt(angleControl);
    }
}


/*  
 void Update()
    {
        if(ControlCheck)
        {
            ControlLookAt();
        }
        else if(ControlCheck == false)
        {
            MyPosition.x = MyPlayer.position.x;
            MyPosition.y = MyPlayer.position.y + 0.5f;
            MyPosition.z = 161.0f;
            gameObject.transform.position = MyPosition;
        }
        if (Input.GetKeyDown("tab"))
        {
            ControlCheck = !ControlCheck;
        }
    }
*/