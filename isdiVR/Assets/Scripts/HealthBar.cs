using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {


	public GameObject prefab;
	public RectTransform barTransform;
	float damage = 100f;
	float increment = 10;
	public AudioSource playSound;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Health()
	{
		
		float heal = 50f;

		if (barTransform.sizeDelta.x > 0) {
			barTransform.sizeDelta = new Vector2 (damage-=20f,barTransform.sizeDelta.y); 
			playSound.Play ();
			
		}

			
					

//		Debug.Log("health damage ");

	}

	public void Instantiate()
	{
		
		if (barTransform.sizeDelta.x > 0) {
			
			Button buttonObj = GetComponentInChildren<Button>();
			Vector3 posAdd = buttonObj.transform.position + ( Vector3.forward * increment );

			GameObject obj = (GameObject)Instantiate( prefab,posAdd,barTransform.rotation );
			increment += 10;
			Debug.Log ("value if increment is" + increment.ToString());
			
		}

	}
}
