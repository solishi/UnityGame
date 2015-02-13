using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {
	public float destroyTime=1f;
	void OnTriggerEnter(Collider col){
		GM.instance.LoseLife ();
		Destroy (col.gameObject);
//		Destroy (Ball, destroyTime);
	}
}
