using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleScript : MonoBehaviour
{
    // positions k values
    [SerializeField] private float posK1 = 1.231f;
    [SerializeField] private float posK2 = 5.3f;
    [SerializeField] private float posK3 = 2.31f;
    // scales K values
    [SerializeField] private float scaleK1 = 1.631f;
    [SerializeField] private float scaleK2 = 1.3f;
    [SerializeField] private float scaleK3 = 4.22f;
    // rotations K values
    [SerializeField] private float rotK1 = 0.231f;
    [SerializeField] private float rotK2 = 1.420f;
    [SerializeField] private float rotK3 = 1.69f;
    // mass 
    [SerializeField] private float massK3 = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(posK1 * Time.time), Mathf.Sin(posK2
            * Time.time), Mathf.Sin(posK3 * Time.time));
        transform.localScale = new Vector3(Mathf.Sin(scaleK1 * Time.time), Mathf.Sin(scaleK2
            * Time.time), Mathf.Sin(scaleK3 * Time.time));
        transform.Rotate(Mathf.Sin(rotK1 * Time.time), Mathf.Sin(rotK2
            * Time.time), Mathf.Sin(rotK3 * Time.time));
        GetComponent<Rigidbody>().mass = Mathf.Sin(massK3 * Time.time);
    }
}
