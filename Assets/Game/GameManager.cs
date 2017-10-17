using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class GameManager : MonoBehaviour {
    private bool gamePaused = false;
    private float initialDeltaTime;
    public bool recording = true;
    private void Start(){
        initialDeltaTime = Time.fixedDeltaTime;
    }
    void Update () {
        if (CrossPlatformInputManager.GetButton("Fire1")){
            recording = false;
        }else{
            recording = true;
        }
        if (Input.GetKeyDown(KeyCode.P)){
            PauseResume();
        }
	}
    void PauseResume(){
        if (!gamePaused){
            gamePaused = true;
            Time.timeScale = 0;
            Time.fixedDeltaTime = 0;
        }else if (gamePaused){
            gamePaused = false;
            Time.timeScale = 1;
            Time.fixedDeltaTime = initialDeltaTime;
        }
    }
}