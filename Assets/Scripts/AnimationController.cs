using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator HatchDoor1Animator;
    // Use this for initialization

    void Start()
    {

        HatchDoor1Animator = GameObject.Find("HatchDoor2").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (EventManager.AllKeysUsed == true)
        {

            HatchDoor1Animator.SetBool("AllKeysUsed", true);
            Debug.Log("Door Opened");
        }
    }
}
