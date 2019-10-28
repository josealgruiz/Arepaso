
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public bool RotateAroundPlayer = true;
    public float RotationSpeed = 0.5f;

    
    // Update is called once per frame
    void Update()
    {
            if(RotateAroundPlayer){
                Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X")* RotationSpeed, Vector3.up);
                offset = camTurnAngle * offset;
            }

        transform.position = player.position + offset;

    }
}
