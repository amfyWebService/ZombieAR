using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpactScript : MonoBehaviour {

    [SerializeField]
    float delay = 0.2f;
    	
	void Update () {

        if(Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(ShowImpact());
        }
		
	}

    IEnumerator ShowImpact()
    {
        GetComponent<Image>().enabled = true;
        yield return new WaitForSeconds(delay);
        GetComponent<Image>().enabled = false;
    }
}
