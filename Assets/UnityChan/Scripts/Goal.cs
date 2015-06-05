using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {


	private void OnTriggerEnter(Collider c){
		c.SendMessage("OnGoal");
	}
}
