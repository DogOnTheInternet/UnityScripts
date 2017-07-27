using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {


	public Rigidbody RB;


	// Use this for initialization
	void Start () {

		RB = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Fire1")) {

			RB.isKinematic = false;
			RB.useGravity = true;
		
		}

	}
}
