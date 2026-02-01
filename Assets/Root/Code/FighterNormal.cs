using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Manager;
using static UnityEngine.GraphicsBuffer;
public class FighterNormal : MonoBehaviour
{
    Vector3 target;
    public bool Stop = false;
    // Start is called before the first frame update
    void Start()
    {
         target = new Vector3(0, transform.position.y, 0);

        transform.LookAt(target);
      
    }

    // Update is called once per frame
    void Update()
    {
        if (!Stop)
        {

        transform.position = Vector3.Lerp(gameObject.transform.position, target, Time.deltaTime);
            if (Vector3.Distance(transform.position, target) <= 2)
            {
                Stop = true;
                gameObject.GetComponent<Animator>().SetBool("hit", true);
                StartCoroutine(hit());

            }
        }

    }

    IEnumerator hit()
    {
        
            Manager.Instance.ScoreDown();
        yield return new WaitForSeconds(1);
        StartCoroutine(hit());

    }
    private void OnMouseDown()
    {

        Dead();
    }


    private void Dead() {
        Stop = true;
        Manager.Instance.Punch(gameObject.transform);
        gameObject.SetActive(false);

    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finisher"))
        {
            Dead();

        }
    }
}
