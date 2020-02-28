using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireScript : MonoBehaviour {

    RaycastHit hit;
    AudioSource myAudioSource;

    [SerializeField]
    Text txtScore;

    [SerializeField]
    GameObject prefabExplosion;

    [SerializeField]
    AudioClip shootSound, explosionSound;

    private int score = 0;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            txtScore.text = "Score " + score;
        }
            
    }

    private void Start()
    {
        GameObject.Find("Best").GetComponent<Text>().text = "Best " + PlayerPrefs.GetInt("score").ToString();
        myAudioSource = GetComponent<AudioSource>();
    }


    void Update () {

        Vector2 center = new Vector2(Screen.width / 2, Screen.height / 2);
        Ray ray = Camera.main.ScreenPointToRay(center);
       
        if(Input.GetButtonDown("Fire1"))
        {
            myAudioSource.PlayOneShot(shootSound);

            if(Physics.Raycast(ray, out hit,Mathf.Infinity))
            {
                Destroy(hit.collider.transform.parent.gameObject);
                GameObject Go = Instantiate(prefabExplosion, hit.transform.position, Quaternion.identity);
                Destroy(Go, 4f);
                myAudioSource.PlayOneShot(explosionSound);
                Score++;
            }
        }

		
	}
}
