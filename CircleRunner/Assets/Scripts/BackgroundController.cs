﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {
    [SerializeField] private float rotateSpeed;

	void Start () {
		
	}
	
	void Update () {
        transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
	}
}
