using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRayCasting : MonoBehaviour
{

    public float rayDistance;
    public RaycastHit rayTouched;

    public bool gotEllipseKey = false;
    public bool gotOvalKey = false;
    public bool gotIsoKey = false;
    public bool gotRectKey = false;

    public bool usedEllipseKey = false;
    public bool usedOvalKey = false;
    public bool usedIsoKey = false;
    public bool usedRectKey = false;

    private KeyHoleController keyHole;
    private KeyControllers key;
    // Use this for initialization
    void Start()
    {
        key = GetComponent<KeyControllers>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRaycast();
        RayCastDetection();
        isUnlocked();
    }

    public void playerRaycast() {
        Debug.DrawRay(this.transform.position, this.transform.forward * rayDistance, Color.cyan);

        if (Physics.Raycast(this.transform.position, this.transform.forward, out rayTouched, rayDistance))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (rayTouched.collider.tag == "Ellipse Key")
                {
                    gotEllipseKey = true;
                    Destroy(rayTouched.transform.gameObject);
                }
                if (rayTouched.collider.tag == "Iso Key")
                {
                    gotIsoKey = true;
                    Destroy(rayTouched.transform.gameObject);
                }
                if (rayTouched.collider.tag == "Oval Key")
                {
                    gotOvalKey = true;
                    Destroy(rayTouched.transform.gameObject);
                }
                if (rayTouched.collider.tag == "Rect Key")
                {
                    gotRectKey = true;
                    Destroy(rayTouched.transform.gameObject);
                }
            }
        }
    }

    void RayCastDetection()
    {
        if (Physics.Raycast(this.transform.position, this.transform.forward, out rayTouched, rayDistance))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (rayTouched.collider.gameObject.tag == "Ellipse KeyHole")
                {
                    if (gotEllipseKey == true)
                    {
                        usedEllipseKey = true;
                            //Play Animation
                            Debug.Log("Unlocked");
                    }
                }

                if (rayTouched.collider.gameObject.tag == "Iso KeyHole")
                {
                    if (gotIsoKey == true)
                    {
                        usedIsoKey = true;
                            //Play Animation
                            Debug.Log("Unlocked");
                    }
                }

                if (rayTouched.collider.gameObject.tag == "Oval KeyHole")
                {
                    if (gotOvalKey == true)
                    {
                        usedOvalKey = true;
                            //Play Animation
                            Debug.Log("Unlocked");
                    }
                }

                if (rayTouched.collider.gameObject.tag == "Rect KeyHole")
                {
                    if (gotRectKey == true)
                    {
                        usedRectKey = true;
                            //Play Animation
                            Debug.Log("Unlocked");
                    }
                }
            }
        }
    }

    void isUnlocked() {
        if (usedEllipseKey == true && usedOvalKey == true && usedIsoKey == true && usedRectKey == true) {
            Debug.Log("AllUnlocked");
        }
    }
}
