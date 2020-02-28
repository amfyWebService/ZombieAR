using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("GameManager").GetComponent<GameManagerScript>().Dead();
    }
}
