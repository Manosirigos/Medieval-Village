using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour {
    public bool display = false;
	// Use this for initialization
	void Start () {
		
	}
    private void OnLevelWasLoaded(int level)
    {
        display = true;
    }
    private void OnGUI()
    {
        if (display == true)
        {
            GUI.Box(new Rect(100, 200, Screen.width - 200, 200), "HOW TO PLAY\n WASD TO MOVE YOUR CHARACTER, LEFT MOUSE BUTTON TO ATTACK \n NOW EXPLORE THE TOWN AND FIND ALL ITS SECRETS ! HAVE FUN ! \n PRESS ESCAPE TO EXIT THIS WINDOW..");
        }
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKey(KeyCode.Escape))
        {
            display = false;
        }
	}
}
