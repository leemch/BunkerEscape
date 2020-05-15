using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHoleController : MonoBehaviour {

	public enum KeyHoleTypes { EllipseKey, IsoKey, OvalKey, RectKey, HatchKey, RedCable, BlueCable, YellowCable, GreenCable };

    public KeyHoleTypes Key;


    /*
    void OnTriggerEnter(Collider other)

    {
        
        string keySlot = this.name;

        if (keySlot == other.gameObject.name+"Slot")
        {
            other.gameObject.transform.position = new Vector3(-45, -3.2f, 2.5f);
            //other.gameObject.SetActive(false);
            
            switch (keySlot)
            {
                case "EllipseKeySlot":

                    break;
                case "OvalKeySlot":
                    
                    break;
                case "RectKeySlot":
                    
                    break;
                case "IsoKeySlot":
                    
                    break;

            }      
        }
        */
    }