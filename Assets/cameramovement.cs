using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float Smooth;
    public Vector2 MaxPosition;
     public Vector2 MinPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // if current positio0n is no equal to the playesr position then...
        if (transform.position != target.position)
        {
            //this creates an off set so the camera doesnt go down the plane
            Vector3 targetposition = new Vector3(target.position.x, target.position.y, transform.position.z);
            //max and min camera position
            targetposition.x = Mathf.Clamp(targetposition.x, MinPosition.x, MaxPosition.x);
            targetposition.y = Mathf.Clamp(targetposition.y, MinPosition.y, MaxPosition.y);
            //Lerp= linear intervalation(it finds the distance between the camera and thge player and moves a fraction of that distance each frame) 
            transform.position = Vector3.Lerp(transform.position, targetposition, Smooth);
        }
}
    } 
