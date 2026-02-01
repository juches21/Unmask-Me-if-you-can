using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float forceUp;
    public float forceForward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       // print("entra triger");
        other.GetComponent<FighterNormal>().Stop=true;
        other.GetComponent<Rigidbody>().AddForce((other.transform.up*forceUp) + (other.transform.forward * forceForward), ForceMode.Impulse);
    }
  
}
