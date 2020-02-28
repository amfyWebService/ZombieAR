using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRobot : MonoBehaviour {

    [SerializeField]
    GameObject AIGo;

    float speed = 0f;

    
	void Start () {
        speed = Random.Range(0.2f, 0.8f);
	}
	
	
	void Update () {
        transform.LookAt(Camera.main.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
		
	}
}
