using UnityEngine;
using System.Collections;
public class Csharp_Example : MonoBehaviour {

	void Update () {
    //Here we say if the cursor is inside this area, then enable custom speed and set the custom speed to 1
    if ((new Rect(50,Screen.height-150-150, 150, 150)).Contains(Input.mousePosition)) {
    SystemCursor.SetCustomSensitivity(1);
    SystemCursor.InsideCustomArea = true;
    } else {
    //if the cursor is not isnide the area but we press the "C" button then the cursor custom speed is set to 12 and it is enabled
    if (Input.GetKey(KeyCode.C)) {
    SystemCursor.SetCustomSensitivity(12);
    SystemCursor.InsideCustomArea = true;
    } else {
    //if cursor is not inside the area and we are not pressing "C" button then the custom cursor sensitivity is disabled and the Global/Local take place
    SystemCursor.InsideCustomArea = false;
    }
    }
	}
	
	void OnGUI () {
    //We are creating some debug/output buttons here to show how to get all the info from the main script
    GUI.Label(new Rect(20,10,1000,100), "<size=18>Current Sensitivity : "+SystemCursor.GetCurrentSensitivity()+"</size>");
    GUI.Label(new Rect(20,40,1000,100), "<size=18>Global Sensitivity : "+SystemCursor.GetGlobalSensitivity()+"</size>");
    GUI.Label(new Rect(20,70,1000,100), "<size=18>Local Sensitivity : "+SystemCursor.GetLocalSensitivity()+"</size>");
    GUI.Label(new Rect(20,100,1000,100), "<size=18>Custom Sensitivity : "+SystemCursor.GetCurrentCustomSensitivity()+"</size>");
    //display some info instructions
    GUI.Label(new Rect(220,270,1000,200), "<size=22>Press and hold 'C' button to change and enable Custom sensitvity to 12 </size>");
    
    //buttons, each one sets the sensitivty to what the text writes
    if (GUI.Button(new Rect (300,10,200,50),"Set Global to 1")) {
    SystemCursor.SetGlobalSensitivity(1);
    }
    if (GUI.Button(new Rect (550,10,200,50),"Set Global to 20")) {
    SystemCursor.SetGlobalSensitivity(20);
    }

    if (GUI.Button(new Rect (300,100,200,50),"Set Local to 1")) {
    SystemCursor.SetLocalSensitivity(1);
    }
    if (GUI.Button(new Rect (550,100,200,50),"Set Local to 20")) {
    SystemCursor.SetLocalSensitivity(20);
    }

    if (GUI.Button(new Rect (300,190,200,50),"Set all to 11")) {
    SystemCursor.SetSensitivity(11);
    }
    if (GUI.Button(new Rect (550,190,200,50),"Reset")) {
    SystemCursor.ResetSensitivity(8);
    }
    //Here we create a box with a green color , the box itself does nothing but display some text , the real code happens in the update function
    GUI.color = Color.green;
    GUI.Button(new Rect(50,150,150,150),"Sensitivity area to 1");

	}
}