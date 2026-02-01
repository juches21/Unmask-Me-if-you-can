using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMove : MonoBehaviour
{

    public Transform OgPoint;
    public Transform TapPoint;
    public bool anim;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (anim == true)
        {
            
                
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, TapPoint.position, Time.deltaTime * timer);
            gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, TapPoint.rotation, Time.deltaTime * timer);
            
            
        }
        else 

        {
            
            
                gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, OgPoint.position, Time.deltaTime * timer);
                gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, OgPoint.rotation, Time.deltaTime * timer);
            
            

        }

    }
}
