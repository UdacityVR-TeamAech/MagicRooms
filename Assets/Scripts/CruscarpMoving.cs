using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CruscarpMoving : MonoBehaviour {

    System.Random getrandom = new System.Random();

	// Use this for initialization
	void Start () {
        InvokeRepeating("MoveCruscarp", 0, 6);
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void MoveCruscarp()
    {
        GameObject cruscarp = this.gameObject;
        Vector3 newPosition = new Vector3(getrandom.Next(-15, 15), 0, getrandom.Next(-15, 15));
        iTween.MoveTo(cruscarp, newPosition, 3.0f);
    }
}
