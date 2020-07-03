using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideSwitcher : MonoBehaviour
{

    public Transform[] targets;
    private Transform target; 

    public bool copyPosition;
    public bool copyRotation;

    private int itarget;

    //public bool findCam = true;
    // Use this for initialization
    void Start()
    {
        itarget = 0;
    }

    public void ForceUpdate()
    {
        // Check bounds on itarget
        if (itarget>=0 )
        {
            target = targets[itarget];

            Debug.Log("Target set to " + target.gameObject.name );
        }



        if (target != null)
        {
            if (copyPosition)
                this.transform.position = target.position;
            if (copyRotation)
                this.transform.rotation = target.rotation;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            itarget = 0;

            Debug.Log("Setting target to 0.");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            itarget = 1;
            Debug.Log("Setting target to 1.");

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            itarget = 2;
            Debug.Log("Setting target to 2.");

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            itarget = 3;
            Debug.Log("Setting target to 3.");

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            itarget = 4;
            Debug.Log("Setting target to 4.");

        }

        ForceUpdate();
    }
}
