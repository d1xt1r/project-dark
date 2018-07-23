using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofSwitch : MonoBehaviour {

    public GameObject player;
    //public GameObject roof;
    public List<Transform> listOfObjectsToHide;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            foreach (var obj in listOfObjectsToHide) {
                obj.gameObject.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            foreach (var obj in listOfObjectsToHide) {
                obj.gameObject.SetActive(true);
            }
        }
    }
}
