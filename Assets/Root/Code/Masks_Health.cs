using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masks_Health : MonoBehaviour
{
    public GameObject mask;
    public GameObject player;
    List<GameObject> maskinchar = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addmask()
    {

        Vector3 playerpos = player.transform.position;
        playerpos.y += (maskinchar.Count*0.05f + 0.01f);
        GameObject newmask = Instantiate(mask, playerpos, player.transform.rotation);
        newmask.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        newmask.transform.SetParent(player.transform);
        maskinchar.Add(newmask);

    }

    public void removemask()
    {
        if (maskinchar.Count >= 6)
        {

            for (int X = 0; X <= 6; X++)
            {

                maskinchar[maskinchar.Count - 1].gameObject.transform.SetParent(null);
                maskinchar[maskinchar.Count - 1].gameObject.AddComponent<Rigidbody>();
                maskinchar[maskinchar.Count - 1].gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.RandomRange(-100, 100), Random.RandomRange(0, 10), Random.RandomRange(-50, 50)));
                maskinchar.Remove(maskinchar[maskinchar.Count - 1]);
            }


        }
        else
        {
            for (int X = 0; X <=maskinchar.Count-1; X++)
            {
                maskinchar[maskinchar.Count - 1].gameObject.transform.SetParent(null);
                maskinchar[maskinchar.Count - 1].gameObject.AddComponent<Rigidbody>();
                maskinchar[maskinchar.Count - 1].gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.RandomRange(-5, 5), Random.RandomRange(0, 10), Random.RandomRange(-5, 5)));
                maskinchar.Remove(maskinchar[maskinchar.Count - 1]);
            }
           
            Manager.Instance.Tap();

        }




    }
}
