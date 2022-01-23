using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;
    void Start()
    {
        InvokeRepeating("SpawnOneCar", Random.Range(0f,2f), Random.Range(3f, 5f));
        
    }

    void SpawnOneCar()
    {
        GameObject g = Instantiate(car, transform.position , Quaternion.identity);

    }
}
