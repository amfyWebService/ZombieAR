using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour {

    [SerializeField]
    FireScript fireScript;
	
	void Start () {
        StartCoroutine("LoadMenu");
	}
	
	IEnumerator LoadMenu()
    {
        int score = fireScript.Score;

        if(score > PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("score", score);
        }

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }
}
