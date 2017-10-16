using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour {
	void Start () {
		
	}
	void Update () {
        Debug.Log("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
        Debug.Log("V: " + CrossPlatformInputManager.GetAxis("Vertical"));
    }
}