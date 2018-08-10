using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class debugObj : MonoBehaviour {

	public GameObject console_text;

	void Start(){
		//ConsoleMessage("test");
	}

	public void ConsoleMessage(string mes){
		console_text.GetComponent<Text>().text = mes;
	}
}
