using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayWin : MonoBehaviour {

	public Text text1;
	public Text text2;
	bool onOff = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleText(int num)
	{

		onOff = !onOff;

		// another kind of logic to switch X or Y
		switch (num) 
		{
		case 1:
			if(onOff)
				text1.text = "X";
			if(!onOff)
				text1.text = "Y";
			break;

		case 2:
			if(onOff)
				text2.text = "X";
			if(!onOff)
				text2.text = "Y";
			break;
		
		default:
			Debug.Log ("wrong input");
			break;
			

		}

	}
}
