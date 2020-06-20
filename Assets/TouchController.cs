using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
	public GameObject[] toggleableObjects;

    void Start()
    {
    	toggleableObjects = GameObject.FindGameObjectsWithTag("Toggleable");    
    }

    void Update()
    {
   		if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Pressed primary button.");
            foreach(GameObject o in toggleableObjects) {
				toggleVisibility(o);
			}
   		}
     	
    }

    private void toggleVisibility(GameObject gameObject) {
    	if(gameObject.activeSelf == true) {
    		hide(gameObject);	
    	} else {
    		show(gameObject);
    	}
    }

    private void show(GameObject gameObject) {
     	gameObject.SetActive(true);
 	}
 	
 	private void hide(GameObject gameObject) {
     	gameObject.SetActive(false);
 	}

}

