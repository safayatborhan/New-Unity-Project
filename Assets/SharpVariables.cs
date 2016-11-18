using UnityEngine;
using System.Collections;

public class SharpVariables : MonoBehaviour {

	// Use this for initialization

	int a=5;
	int b=7;
	int sum,sub;
	void Start () {
		sum = a + b;
		sub = b - a;
		Debug.Log (sum);
		Debug.Log (sub);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
