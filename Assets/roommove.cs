using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roommove : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 cameraChange;
    public Vector3 playerChange;
    private cameramovement cam;
    void Start()
    {
        cam = Camera.main.GetComponent<cameramovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the player interacts with the transitioner 
        if (collision.CompareTag("Player"))
        {
            cam.MinPosition += cameraChange;
            cam.MaxPosition += cameraChange;
            collision.transform.position += playerChange;
        }
    }
}

