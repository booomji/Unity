using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEventSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame


	public void SwitchFunc(int num)
	{
		switch(num)
		{
		case 1:
			print ("intput X");
			break;

		case 2:
			print ("input Y");
			break;

		default:
			print ("invalid arg");
			break;
		
		}

	}

	public void TestFunc(int num)
	{
		Debug.Log (num.ToString() + "test");
//		print (num.ToString() + "test");
	}
}
