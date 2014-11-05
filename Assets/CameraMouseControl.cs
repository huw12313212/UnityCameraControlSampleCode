using UnityEngine;
using System.Collections;

public class CameraMouseControl : MonoBehaviour {

	public float X = 0;
	public float Y = 0;

	public float tempX = 0;
	public float tempY = 0;

	public Transform dummyX;
	public Transform dummyY;

	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
			tempX = Input.mousePosition.x;

			Debug.Log (tempX);
			tempY = Input.mousePosition.y;
		}

		if(Input.GetMouseButton(0))
		{
			float diffX = Input.mousePosition.x - tempX;
			float diffY = Input.mousePosition.y - tempY;

			X += diffX;
			Y += diffY;

			if(Y>90)Y=90;
			else if(Y<-90) Y = -90;

			dummyX.localRotation = Quaternion.Euler(0,X,0);
			dummyY.localRotation = Quaternion.Euler(Y,0,0);

			tempX = Input.mousePosition.x;
			tempY = Input.mousePosition.y;
		}
	
	}
}
