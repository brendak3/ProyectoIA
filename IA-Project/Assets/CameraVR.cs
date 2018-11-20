using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class CameraVR : MonoBehaviour {
    [SerializeField] private float m_RenderScale = 1f;
	// Use this for initialization
	void Start () {
        UnityEngine.XR.XRSettings.eyeTextureResolutionScale = m_RenderScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
