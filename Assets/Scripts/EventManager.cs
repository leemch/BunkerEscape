using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public static bool usedEllipseKey = false;
    public static bool usedIsoKey = false;
    public static bool usedOvalKey = false;
    public static bool usedRectKey = false;
    public static bool usedHatchKey = false;
    public static bool AllKeysUsed = false;
    public static bool usedRedCable = false;
    public static bool usedYellowCable = false;
    public static bool usedBlueCable = false;
    public static bool usedGreenCable = false;
    public static bool AllCablesUsed = false;
    public static bool KeyPadCorrect = false;

    public Animator HatchDoor1Pivot;
    public Animator HatchDoor2Pivot;
    public Animator HatchDoor3Pivot;
    public Animator SafeDoorPivot;

    // Use this for initialization
    void Awake()
    {
        Instance = this;

        //HatchDoor1Pivot = GetComponent<Animator>();
        //HatchDoor2Pivot = GetComponent<Animator>();
        //HatchDoor3Pivot = GetComponent<Animator>();

        HatchDoor1Pivot = GameObject.Find("HatchDoor1Pivot").GetComponent<Animator>();
        HatchDoor2Pivot = GameObject.Find("HatchDoor2Pivot").GetComponent<Animator>();
        HatchDoor3Pivot = GameObject.Find("HatchDoor3Pivot").GetComponent<Animator>();
        SafeDoorPivot = GameObject.Find("SafeDoorPivot").GetComponent<Animator>();

    }

    void Update()
    {
        if (AllKeysUsed == false)
        {
            if (usedEllipseKey == true && usedIsoKey == true
                && usedOvalKey == true && usedRectKey == true)
            {

                Debug.Log("All Keys Used");
                AllKeysUsed = true;

                if (AllKeysUsed == true) {
                    HatchDoor1Pivot.SetBool("AllKeysUsed", true);
                }
                
            }
        }

        if (usedHatchKey == true) {
            Debug.Log("HatchKey Used");
            usedHatchKey = true;

            if (usedHatchKey == true) {
                HatchDoor2Pivot.SetBool("HatchKeyUsed", true);
            }

        }

        if (AllCablesUsed == false)
        {
            if (usedBlueCable == true && usedGreenCable == true
                && usedRedCable == true && usedYellowCable == true)
            {

                Debug.Log("All Cables Used");
                AllCablesUsed = true;

                if (AllCablesUsed == true)
                {
                    HatchDoor3Pivot.SetBool("AllCablesUsed", true);
                }

            }
        }

        if (KeyPadCorrect == true)
        {
           

                //Debug.Log("Safe opened");
                SafeDoorPivot.SetBool("codeCorrect", true);
        }
        
    }

}