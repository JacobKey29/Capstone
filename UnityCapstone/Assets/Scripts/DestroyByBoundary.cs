using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

    /// <summary>
    /// Detects when an object is leaving the boundary area and destroys that object
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit(Collider other) {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);
    }
}
