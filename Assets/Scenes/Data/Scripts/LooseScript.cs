using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LooseScript : MonoBehaviour {
       
    private void OnCollisionEnter(Collision collision)
    {
        var rigidBody = collision.gameObject.GetComponent<Rigidbody>();


        if (rigidBody)
        {
            GameObject.Find("GameManager").GetComponent<GameManagerScript>().Dead();
        }
    }
}
