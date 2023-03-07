using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public GameObject door;

    // Use this for initialization
    void Start () {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            door.transform.Rotate(0, 90, 0);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            door.transform.Rotate(0, -90, 0);
        }
    }

    // Update is called once per frame
    void Update () {
       
	}
}
