using UnityEngine;
using System.Collections;
namespace UnityChan{

public class PlayerController : MonoBehaviour {

	Animator anim;
	UnityChanControlScriptWithRgidBody unitychan;
	// Use this for initialization
	void Start () {
			anim = GetComponent< Animator >();
			unitychan = GetComponent< UnityChanControlScriptWithRgidBody >();

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGoal(){
		anim.SetBool ("Win", true);
		unitychan.enabled = false;
	}

		void OnCollisionStay(Collision c){
			if(c.gameObject.tag == "Floor"){
				transform.parent = c.gameObject.transform;
			}
		}
		
		void OnCollisionExit(Collision c){
			transform.parent = null;
		}
	}
}