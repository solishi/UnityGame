using UnityEngine;
using System.Collections;
public class Lazer: MonoBehaviour {

	Transform player;               // Reference to the player's position.
	public float ballInitialVelocity = 600f;
	private Rigidbody rb;
	private bool ballInPlay=false;
	private float destroyTime=0.5f;
//	public float dy;
	// Use this for initialization
	void Start () {
//		dy=player.rotation.y;

		rb = GetComponent<Rigidbody> ();
		Transform  cam  = Camera.main.transform;
		Vector3 cameraRelativeRight   = cam.TransformDirection (Vector3.forward);
		// Apply a force relative to the camera's x-axis
		rb.AddForce (cameraRelativeRight * 200);
		rb.useGravity = false;
		//	player = GameObject.FindGameObjectWithTag ("Player").transform;
	//	Vector3 dir = Quaternion.AngleAxis(100, Vector3.forward) * Vector3.right;
	//	rb.AddForce(dir*100f);
	//	rb.AddTorque (0, 100, 0);
	//	rb.AddForce (-5f,  Mathf.Cos(50)*10f, 5f);
	//	rb.AddForce(new Vector3(0f,0f,Random.value*100f-50f));
	}
	void Awake () {
		rb = GetComponent<Rigidbody> ();

	}
	// Update is called once per frame
	void Update () {
	//	if (!ballInPlay) {
	//			rb.AddForce(new Vector3(Random.value*10f,Random.value*20f,0));
	//		ballInPlay=true;
	//	}
	//	rb.AddForce(new Vector3(Random.value*1f,0,Random.value*2f));

	//	if (Input.GetKeyDown ("z")/*&& ballInPlay == false*/) 
		/*	{
			transform.parent=null;
			ballInPlay =true;
			rb.isKinematic=false;
			rb.AddForce(new Vector3(ballInitialVelocity,ballInitialVelocity,0));
		}*/

	}
	void OnCollisionEnter(Collision other){
		Destroy (this.gameObject);
	}
	public void Force(float InitialVelocityx,float InitialVelocityy,float InitialVelocityz){
		rb.AddForce(new Vector3(InitialVelocityx,InitialVelocityy,InitialVelocityz));
	}
}
