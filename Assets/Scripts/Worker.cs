using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Worker : MonoBehaviour
{
     CookieClicker2 clicker;


    // Start is called before the first frame update
    void Start()
    {
        clicker = GetComponent<CookieClicker2>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("got a cookie");
        clicker.counter++;
    }
}
