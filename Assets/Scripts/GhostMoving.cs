using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMoving : MonoBehaviour
{

    System.Random getGhostrandom = new System.Random();

	// Use this for initialization
	void Start () {
        InvokeRepeating("MoveCruscarp", 7, 6);
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void MoveCruscarp()
    {
        GameObject cruscarp = this.gameObject;
        Vector3 newPosition = new Vector3(getGhostrandom.Next(-15, 15), 0, getGhostrandom.Next(-15, 15));
        iTween.MoveTo(cruscarp, newPosition, 3.0f);
    }
}
