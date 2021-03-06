using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	public bool locked;
	public bool opening;
	public bool getkey;


    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		if (!locked && opening){ 

			if(transform.position.y < 7.7f) 

			 
			transform.Translate (0, 7f * Time.deltaTime, 0, Space.World);
		}
		

    }

    public void OnDoorClicked() {
		// If the door is clicked and unlocked
		// Set the "opening" boolean to true
		// (optionally) Else
		// Play a sound to indicate the door is locked
		if (locked == false) {
			opening = true;
	
		}


	}

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;

    }
}
