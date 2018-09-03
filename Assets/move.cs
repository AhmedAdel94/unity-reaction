using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	Transform p1Transform;
	float lastMove;
	float timeBetweenMoves = 0.15f;
	Vector3 direction;
	Vector3 p1;
	Vector3 p2;

	public GameObject target;

	public Camera fpsCam;

	public GameObject player;

	public string message = "Hello There";
	bool mess = false;


	void Update () {
        //transform.Rotate(z, 0, 0);
        if(Input.GetKey(KeyCode.W))
		{
			//Debug.Log("Move Up");
			transform.position += Vector3.forward * Time.deltaTime * 3;
		}

		if(Input.GetKey(KeyCode.S))
		{
			//Debug.Log("Move Up");
			transform.position += Vector3.back * Time.deltaTime * 3;
		}

		if(Input.GetKey(KeyCode.D))
		{
			//Debug.Log("Move Up");
			transform.position += Vector3.right * Time.deltaTime * 3;
		}

		if(Input.GetKey(KeyCode.A))
		{
			//Debug.Log("Move Up");
			transform.position += Vector3.left * Time.deltaTime * 3;
		}
		
		 p1 = GameObject.Find("Char2").transform.position;
		 p2 = GameObject.Find("Char1").transform.position;
		
		//Debug.Log(p1);
		if(p2.z - p1.z < 2)
		{	
			mess = true;
			// Debug.Log("Hello there");
		}else
		{
			mess = false;
		}
	}

	void OnGUI(){
		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = 30;
		myStyle.normal.textColor = Color.black;
		if(mess){
			message = "Press E to interact";
			GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 500f, 500f), message,myStyle);
		}
		if(Input.GetKey(KeyCode.E))
		{
			mess=false;
			message = "Hello There";
			GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 500f, 500f), message,myStyle);
		}

	}
}
