using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
     GameObject prefab;

    public bool Fin;
    public List<GameObject> ListSpawner;
    public List<GameObject> ListEnemy;



    public int RoundNum = 10;
    public float RoundTime = .01f;
    // Start is called before the first frame update
    void Start()
    {
        NextRownd();
        StartRownd();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartRownd()
    {
        Fin = false;
        StartCoroutine(create(RoundNum, RoundTime));
    }
    public void StopRownd()
    {
        StopAllCoroutines();
    }
    GameObject save;
    IEnumerator create(int NumberOfEnemies, float Interval)
    {

        for (int i = 0; i < NumberOfEnemies; i++)
        {
            yield return new WaitForSeconds(Interval);

            prefab = ListEnemy[Random.RandomRange(0,3)];
            int Index = Random.Range(0, ListSpawner.Count);
            Instantiate(prefab, ListSpawner[Index].transform.position, ListSpawner[Index].transform.rotation);
            if (save != null)
            {

                ListSpawner.Add(save);
            }

            save = ListSpawner[Index];
            ListSpawner.RemoveAt(Index);




        }


        yield return new WaitForSeconds(2);
        NextRownd();
        StartRownd();
    }


    void NextRownd()
    {
        RoundNum += 5;
        if (RoundTime >= 0.15)
        {

            RoundTime = RoundTime - RoundTime * 0.15f;
        }

       
    }
}
