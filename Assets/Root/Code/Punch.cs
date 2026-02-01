using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{

    public Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(gameObject.transform.position, target, 7f*Time.deltaTime);
        transform.localScale *= 1.01f;
        if (Vector3.Distance(transform.position, target) <= 1)
        {
            Destroy(gameObject);
        }
    }
}
