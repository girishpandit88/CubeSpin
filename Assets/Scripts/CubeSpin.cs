﻿using UnityEngine;
using System.Collections;

public class CubeSpin : MonoBehaviour {

	public float speed = 100f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.down,speed*Time.deltaTime);
	}
}
