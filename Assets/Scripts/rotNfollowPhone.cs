using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotNfollowPhone : MonoBehaviour
{
  private Touch initTouch = new Touch();

    public Transform PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 5.0f;

	// Use this for initialization
	void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;	
	}
	
	// LateUpdate is called after Update methods
	void LateUpdate () {

        if(RotateAroundPlayer)
        {
        foreach(Touch touch in Input.touches){
           if(touch.phase == TouchPhase.Began){
               initTouch = touch;
           }else if(touch.phase == TouchPhase.Moved){
                float deltaX = initTouch.position.x - touch.position.x;
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(-deltaX * RotationsSpeed, Vector3.up);

            _cameraOffset = camTurnAngle * _cameraOffset;
        } else if(touch.phase == TouchPhase.Ended){
               initTouch = new Touch();
           }
       } 
       }
        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
    

    }
}