using UnityEngine;
using System.Collections;

public class TestButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (">>");
		UIButton button = UIButton.create ("buttonGeenDown.png","buttonGeenUp.png",0,0);
	}

}
