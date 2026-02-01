using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFinisher : MonoBehaviour
{
    //float scaleee = 0;
    public bool spherecreated = true; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale += new Vector3(Time.deltaTime*7, Time.deltaTime *7, Time.deltaTime * 7);
        
        if (transform.localScale.y >= 7)
        {
            spherecreated = false;
            Destroy(gameObject);
        }
    }
}
