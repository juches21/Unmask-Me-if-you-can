using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class Manager : MonoBehaviour
{
    public static Manager Instance;


    public int Score = 0;
    public int ScoreFinisher = 0;

    public TextMeshProUGUI textMeshPro;
    public Slider sliderFinisher;

    public GameObject FinisherPre;

    public GameObject Fist;


    public GameObject Player;
    public GameObject armature;





    public GameObject TapUI;

    public Button FinisherButon;
    Masks_Health MasksHealth;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MasksHealth = gameObject.GetComponent<Masks_Health>();

    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreFinisher >= 15)
        {
            FinisherButon.interactable = true;
        }
        else
        {
            FinisherButon.interactable = false;

        }
    }

    Quaternion roti;
    public void Punch(Transform enemigo)
    {
        Vector3 target = new Vector3(enemigo.position.x, Player.transform.position.y, enemigo.position.z);
        Player.transform.LookAt(target);
        armature.GetComponent<Animator>().SetTrigger("hit");
        GameObject fistactual = Instantiate(Fist, new Vector3(0, 2, 0), roti = Quaternion.Euler(-90f, 90f, 0f));
        fistactual.GetComponent<Punch>().target = enemigo.localPosition;

        ScoreUp();
    }
    public void ScoreUp()
    {

        Score++;
        ScoreFinisher++;
        MasksHealth.addmask();
        textMeshPro.text = Score + "";
        sliderFinisher.value = ScoreFinisher;

       


    }
    public void ScoreDown()
    {
        Score-=6;
        ScoreFinisher = 0;
        MasksHealth.removemask();
        sliderFinisher.value = 0;

        if (Score < 0)
        {
            Score = 0;
        }
        textMeshPro.text = Score + "";
    }
    public bool ultimavegade;
    public void Tap()
    {
        GameObject.FindGameObjectWithTag("enemy").gameObject.SetActive(false);
        //print("entra");
        if (!ultimavegade)
        {
            ultimavegade = true;
            TapUI.SetActive(true);
            gameObject.GetComponent<Spawn>().StopRownd();
            GameObject.Find("Main Camera").GetComponent<CameraMove>().anim = true;
        }
    }

    public void TapEnd()
    {
        TapUI.SetActive(false);
        gameObject.GetComponent<Spawn>().StartRownd();
        GameObject.Find("Main Camera").GetComponent<CameraMove>().anim = false;
    }

    public void EndGame()
    {

    }

    public void Finisher()
    {

        Instantiate(FinisherPre, new Vector3(0, 2, 0), Quaternion.identity);
        armature.GetComponent<Animator>().SetTrigger("finisher");

        ScoreFinisher = 0;
    }






}
