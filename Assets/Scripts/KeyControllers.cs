using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControllers : MonoBehaviour
{

    public enum KeyTypes { EllipseKey, IsoKey, OvalKey, RectKey, HatchKey, RedCable, BlueCable, YellowCable, GreenCable };

    public KeyTypes Key;

    void OnTriggerEnter(Collider other) {

        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.EllipseKey && this.Key == KeyTypes.EllipseKey)
        {
            Debug.Log("EllipseKey Used");
            EventManager.usedEllipseKey = true;

            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.IsoKey && this.Key == KeyTypes.IsoKey)
        {
            Debug.Log("IsoKey Used");
            EventManager.usedIsoKey = true;
            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.OvalKey && this.Key == KeyTypes.OvalKey)
        {
            Debug.Log("OvalKey Used");
            EventManager.usedOvalKey = true;
            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.RectKey && this.Key == KeyTypes.RectKey)
        {
            Debug.Log("RectKey Used");
            EventManager.usedRectKey = true;
            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.HatchKey && this.Key == KeyTypes.HatchKey)
        {
            Debug.Log("HatchKey Used");
            EventManager.usedHatchKey = true;
            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.RedCable && this.Key == KeyTypes.RedCable)
        {
            Debug.Log("RedCable Used");
            EventManager.usedRedCable = true;
            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.YellowCable && this.Key == KeyTypes.YellowCable)
        {
            Debug.Log("RedCable Used");
            EventManager.usedYellowCable = true;
            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.BlueCable && this.Key == KeyTypes.BlueCable)
        {
            Debug.Log("RedCable Used");
            EventManager.usedBlueCable = true;
            Destroy(this.transform.gameObject);
        }
        if (other.transform.GetComponent<KeyHoleController>().Key == KeyHoleController.KeyHoleTypes.GreenCable && this.Key == KeyTypes.GreenCable)
        {
            Debug.Log("RedCable Used");
            EventManager.usedGreenCable = true;
            Destroy(this.transform.gameObject);
        }
    }
}