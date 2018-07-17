using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour {

    public GameObject player;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            player.transform.parent = transform; // when game object with name player enter this trigger it becomes chiled to the game object that this script is attached to
            print("e kvo de");
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            player.transform.parent = null; // when the player exit the trigger it will no longer be childed to the game object that this script is attached to
        }
    }

}
