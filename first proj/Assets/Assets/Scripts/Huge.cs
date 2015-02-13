using UnityEngine;
using System.Collections;
public class Huge: MonoBehaviour {

	Transform player;               // Reference to the player's position.
	public float ballInitialVelocity = 600f;
	public Bullet bullet;
	private Bullet tbull;
	private Rigidbody rb;
	private bool ballInPlay=false;
	private float destroyTime=0.5f;
	private int round=0;
	public float spawnTime = 1f;            // How long between each spawn.

//	public float dy;
	// Use this for initialization
	void Start () {
		Transform  cam  = Camera.main.transform;

		Vector3 cameraRelativeForward   = cam.TransformDirection (Vector3.forward);


		rb = GetComponent<Rigidbody> ();
		// Apply a force relative to the camera's x-axis
		rb.AddForce (cameraRelativeForward * 50);
		rb.AddForce (0f,  10f, 0f);

		InvokeRepeating ("Spawn", spawnTime, spawnTime);

	}
	void Spawn(){

		if (round < 2) 
		{
			round++;		
		} 
		else {
			Transform  cam  = Camera.main.transform;

			Vector3 cameraRelativeForward   = cam.TransformDirection (Vector3.forward);

			Vector3 cameraRelativeRight  = cam.TransformDirection (Vector3.right);
			Vector3 temppos=this.transform.position;
			for (int i=0;i<2;i++){
				int j=Random.Range(-10, 10);
				int k=Random.Range(-10, 10);

				tbull=Instantiate (bullet, temppos+(j)*cameraRelativeForward+(k)*cameraRelativeRight, cam.rotation ) as Bullet;
				tbull.Reset();
			//	tbull.Force(-cameraRelativeForward*100);		
				tbull.Force((j)*cameraRelativeForward+(k)*cameraRelativeRight);

			}
			Destroy(gameObject);

		}

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
