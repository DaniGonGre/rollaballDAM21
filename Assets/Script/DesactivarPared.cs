using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DesactivarPared : MonoBehaviour {

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            gameObject.SetActive(false);
        }
    }
}
