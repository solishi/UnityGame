using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
//	public int collisiontype =10;
	public float paddleSpeed = 1f;
	private Vector3 playerPos=new Vector3(0,-9.5f,0);
	private Vector3 bulPos = new Vector3 (0, -10f, 0);
	public Bullet bullet;
	private Bullet temp;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f),-9.5f,0f);
		transform.position = playerPos;

		if (Input.GetKeyDown ("z")/*&& ballInPlay == false*/) 
		{

			bulPos=transform.position;
			bulPos.y+=1f;
			temp=Instantiate (bullet, bulPos, Quaternion.identity)as Bullet;
		//	temp.Force(600f);
		//	temp.ballInitialVelocity=500f;
		//	temp.rb.AddForce(new Vector3(0,InitialVelocity,0));

		}


	}
}
