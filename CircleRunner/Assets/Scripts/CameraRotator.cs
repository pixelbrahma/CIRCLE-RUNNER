﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour {

    [SerializeField] private float rotation;

    void Start () {
		
	}

	void Update () {
        transform.Rotate(0f, 0f, rotation * Time.deltaTime);
	}
}
