using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Crowds : MonoBehaviour
{
    
    public GameObject[] crowd;
    public GameObject[] spawns;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject c in spawns)
        {
            int n = Random.RandomRange(0, 3);
            crowd[n].transform.rotation = Quaternion.Euler(0, 0, 0);
           GameObject test = Instantiate(crowd[n], c.transform.position, crowd[n].transform.rotation);
            test.transform.LookAt(new Vector3(0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
