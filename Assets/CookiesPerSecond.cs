using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookiesPerSecond : MonoBehaviour
{
    public Text cps;
    public Grandma grand;
    public Worker work;
    public Factory fact;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Worker>();
        GetComponent<Grandma>();
        GetComponent<Factory>();
    }

    // Update is called once per frame
    void Update()
    {
        cps.text = "Automatic Cookies Per Second (cps):\n" + (grand.amountOfGrandmas + (work.amountOfWorkers * 25) + (fact.amountOfFactories * 500));
    }
}
