using UnityEngine;
using System.Collections;

public class FollowRotateWPlayer : MonoBehaviour
{
  
    public GameObject player;
    public float RotationsSpeed = 5.0f;
    private Vector3 _cameraOffset;
    // Use this for initialization
    void Start () {
         _cameraOffset = transform.position - player.transform.position;	
    }
 
    void LateUpdate() {
    
        float deltaY = player.transform.rotation.y;
        Quaternion camTurnAngle = Quaternion.AngleAxis(-deltaY*500 * RotationsSpeed, Vector3.up);
    _cameraOffset = camTurnAngle * _cameraOffset;
    }

    
}


