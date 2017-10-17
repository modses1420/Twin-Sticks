using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {
    private const int bufferFrames = 500;
    private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
    private Rigidbody rigidBody;
    private GameManager manager;
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        manager = GameObject.FindObjectOfType<GameManager>();
	}
	void Update () {
        if (manager.recording){
            Record();
        }else{
            PlayBack();
        }
    }
    void PlayBack(){
        rigidBody.isKinematic = true;
        int frame = Time.frameCount % bufferFrames;
        transform.position = keyFrames[frame].position;
        transform.rotation = keyFrames[frame].rotation;
    }
    void Record(){
        rigidBody.isKinematic = false;
        int frame = Time.frameCount % bufferFrames;
        float time = Time.time;
        keyFrames[frame] = new MyKeyFrame(time, transform.position, transform.rotation);
    }
}
/// <summary>
/// A structure for storing time, position, and rotation.
/// </summary>
public struct MyKeyFrame{
    public float frameTime;
    public Vector3 position;
    public Quaternion rotation;
    public MyKeyFrame(float aTime, Vector3 aPosition, Quaternion aRotation){
        frameTime = aTime;
        position = aPosition;
        rotation = aRotation;
    }
}