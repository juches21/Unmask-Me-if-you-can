using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tap : MonoBehaviour
{

    public int Time;
    public float TaperValue;
    public float TaperAdd;
    public int TaperValuenegative;
    public int TaperValueMax;
    public GameObject referee;
    public GameObject TapUI;

    public GameObject Count1;
    public GameObject Count2;
    public GameObject Count3;

    public Slider ValueSlider;

    public GameObject video;

    
    public GameObject reff;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Resist());
        StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {

        ValueSlider.value = TaperValue;

        if (TaperValue >= TaperValueMax)
        {
            //gana
            Manager.Instance.TapEnd();
            TaperValue = 0;
            referee.SetActive(false);
            StopAllCoroutines();
        }
        if (Time > 0 && TaperValue < TaperValueMax)
        {
            //pierde

            //TapUI.SetActive(false);
            Manager.Instance.EndGame();
        }
    }
    public void startvid()
    {
        StartCoroutine(vide());

    }
    public void Push()
    {
        TaperValue += TaperAdd;
    }

    IEnumerator Resist()
    {

        TaperValue -= Random.RandomRange(.5f, 1.6f);
        yield return new WaitForSeconds(Random.RandomRange(0.2f, 1.6f));
        StartCoroutine(Resist());


    }
    IEnumerator CountDown()
    {
        referee.SetActive(true);
        referee.GetComponent<Animation>().playAutomatically = true;
     
           
            yield return new WaitForSeconds(1);

            Count1.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);



            Count2.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);



            Count3.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);

            //TapUI.SetActive(false);
            StartCoroutine(vide());


        
            
        

    }

    IEnumerator vide()
    {
        video.gameObject.SetActive(true);

        yield return new WaitForSeconds(39);
        Application.Quit();
    }

}
