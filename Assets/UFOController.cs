using UnityEngine;
using System.Collections;

public class UFOController : MonoBehaviour {
	bool LeftFlag;
	bool UpFlag;
	// Use this for initialization
	void Start () {
		LeftFlag = false;
		UpFlag = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.LeftArrow) && LeftFlag == false) {
			transform.position += new Vector3(-3.0f , 0.0f , 0.0f) * Time.deltaTime;
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow))
			LeftFlag = true;
			

		if (Input.GetKey(KeyCode.UpArrow) && UpFlag == false) {
			transform.position += new Vector3(0.0f , 0.0f , 3.0f) * Time.deltaTime;
		}
		if (Input.GetKeyUp (KeyCode.UpArrow))
			UpFlag = true;

		if (LeftFlag == true && UpFlag == true) {

			}

		/*if (Input.GetKey(KeyCode.RightArrow)) {
			transform.position += new Vector3(3.0f , 0.0f , 0.0f) * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.position += new Vector3(0.0f , 0.0f , -3.0f) * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.Return)) {
			transform.position += new Vector3(0.0f , -4.0f , 0.0f) * Time.deltaTime;
		}	

		if (Input.GetKey(KeyCode.Space)) {
			transform.position += new Vector3(0.0f , 4.0f , 0.0f) * Time.deltaTime;
		}*/

	}
}
