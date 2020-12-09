using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotSpawner : MonoBehaviour
{

    [SerializeField] float timeInterval = 3f;
   [SerializeField] GameObject[] Food=new GameObject[2];
    [SerializeField] float maxX = 0f;
    // Start is called before the first frame update
    public static CarrotSpawner  instance;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartSpawining();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   void spawnRandom()
    {
        int rand = Random.Range(0, Food.Length);
        float posX = Random.Range(-maxX, maxX);
        Vector3 RandomX = new Vector3(posX, transform.position.y, transform.position.z);
        Instantiate(Food[rand],RandomX,transform.rotation);
    }


IEnumerator Freefall()
    {
        yield return new WaitForSeconds(2f);
        while(true)
        {
            spawnRandom();
            
            yield return new WaitForSeconds(timeInterval);
        }
    }


    void StartSpawining()
    {
        StartCoroutine("Freefall");
    }
    public void StopSpawining()
    {
        StopCoroutine("Freefall");
    }



}
