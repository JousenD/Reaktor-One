using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Camera camera;

    [SerializeField] float movementSpeed = 10f;

    // Use this for initialization
    void Start () {
        camera = FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 cameraPosition = camera.transform.position;
        Vector3 newCameraPosition = new Vector3 (transform.position.x, cameraPosition.y,cameraPosition.z);
        camera.transform.position = newCameraPosition;

        if(Input.GetKey("d"))
        {
            print("D");
            transform.position = transform.position + Vector3.right * Time.deltaTime * movementSpeed;
        }


        if (Input.GetKey("a"))
        {
            print("A");
            transform.position = transform.position - Vector3.right * Time.deltaTime * movementSpeed;
        }
    }
}
