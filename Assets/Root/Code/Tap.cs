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

    public GameObject Count1;
    public GameObject Count2;
    public GameObject Count3;

    public Slider ValueSlider;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Resta());
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
            TaperValue=0;
            referee.SetActive(false);
            StopAllCoroutines();
        }
        if (Time > 0 && TaperValue < TaperValueMax)
        {
            //pierde
            Manager.Instance.EndGame();
        }
    }

    public void Push()
    {
        TaperValue += TaperAdd;
    }

    IEnumerator Resta()
    {

        TaperValue -= Random.RandomRange(.5f, 1.6f);
        yield return new WaitForSeconds(Random.RandomRange(0.2f,1.6f));
        StartCoroutine(Resta());


    }
    public bool ultimavegade;
    public GameObject reff;
    IEnumerator CountDown()
    {
        referee.SetActive(true);
        referee.GetComponent<Animation>().playAutomatically = true;
        if(ultimavegade==false)
        {
            ultimavegade = true;
            yield return new WaitForSeconds(1);

            Count1.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);



            Count2.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);



            Count3.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
        }
        else
        {
            //fin de juego
            print("fin de juego manin");
        }

    }

}
