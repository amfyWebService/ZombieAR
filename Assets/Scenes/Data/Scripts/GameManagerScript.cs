using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField]
    GameObject ParentGameObject;

    [SerializeField]
    GameObject PrefabRobot;

    [SerializeField]
    float rayon = 10f, delay = 0.5f, rangeY = 5f;

    [SerializeField]
    GameObject Looser;

    void Start()
    {
        //Run();
    }

    public void Run()
    {
        InvokeRepeating("Spawn", 0f, delay);
    }

    void Spawn()
    {
        int angle = Random.Range(1, 360);
        Vector3 pos = Vector3.zero;
        pos.x = transform.position.x + rayon * Mathf.Cos(angle);
        pos.z = transform.position.z + rayon * Mathf.Sin(angle);
        pos.y = Random.Range(-rangeY, rangeY);

        GameObject go = Instantiate(PrefabRobot, pos, Quaternion.identity);
        go.transform.parent = ParentGameObject.transform;
    }

    public void Dead()
    {
        Looser.SetActive(true);
    }
}
