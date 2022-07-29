using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject parent;
    public float time = 2f;
    public float repeatRate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", time, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation, parent.transform);
    }
}
