using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class AnimationOnTrigger : MonoBehaviour {

    public List<PlayableDirector> playableDirectors;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            foreach (PlayableDirector playableDirector in playableDirectors) {
                playableDirector.Play();
            }
        }
    }

}
