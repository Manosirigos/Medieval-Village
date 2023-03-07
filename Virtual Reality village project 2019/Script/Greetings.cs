using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greetings : MonoBehaviour {

    bool display = false;
    public string text;
    public GameObject peasant;
    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            audio.Play();
            display = true;
        }
        
    }

    private void OnGUI()
    {
        if (display == true)
        {
            GUI.Box(new Rect(100, 200, Screen.width - 200, 200), text);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        display = false;
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            display = false;
        }
    }
}
