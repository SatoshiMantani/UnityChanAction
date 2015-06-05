using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCTriggerEnter(Collider col){

		col.SendMessage ("OnGoal");
		//Debug.Log ("Goal!");

	}
}
