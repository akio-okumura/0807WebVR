using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmition : MonoBehaviour {

	public WebVRManager _WebVRManager;

	public void Transmit_OnStartVR() {
		_WebVRManager.OnStartVR();
	}

	public void Transmit_OnEndVR() {
		_WebVRManager.OnEndVR();
	}

	public void Transmit_OnWebVRData(string jsonString) {
		_WebVRManager.OnWebVRData(jsonString);
	}

	public void Transmit_TogglePerf() {
		_WebVRManager.TogglePerf();
	}

	public void Transmit_TestTime() {
		_WebVRManager.TestTime();
	}
}
