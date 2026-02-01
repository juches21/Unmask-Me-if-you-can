using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usher : MonoBehaviour
{
    public List<GameObject> ListSpawner;
    public List<GameObject> ListNpc;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ListSpawner.Count; i++)
        {
           // Instantiate(List[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
