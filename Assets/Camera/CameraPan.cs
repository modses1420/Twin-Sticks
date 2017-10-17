using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour {
	void Start () {
		
	}
	void Update () {
		Debug.Log("RHoriz " + Input.GetAxis("RHoriz"));
	}
}
