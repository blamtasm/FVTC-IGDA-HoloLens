using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCannonController : MonoBehaviour {

    private GameObject camera;
    private bool isPlaced = false;

	// Use this for initialization
	void Start () {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            if (!isPlaced)
            {
                RaycastHit hit;
                if (Physics.Raycast(camera.GetComponent<Transform>().position, camera.GetComponent<Transform>().forward, out hit))
                {
                    //place turret
                    isPlaced = true;
                }
            }
            else
            {
                //controls for using turret
            }
        }
	}
}
