using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
		
	// Use this for initialization
	void Start () {
	
		GameObject AudioHelper = (GameObject)Instantiate(Resources.Load("AudioHelper"));
		AudioHelper.GetComponent<AudioScript>().audioInput = "StartRolling";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
