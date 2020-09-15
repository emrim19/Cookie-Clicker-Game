using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerScript : MonoBehaviour
{

    public int cookieCounter;
    public int clickCounter;
    public Text cookieText;
    public Text counterText;
    public Upgrade up;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Upgrade>();
        cookieCounter = 0;
        clickCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cookieText.text = "Cookies:\n" + cookieCounter;
        counterText.text = "Clicks: " + clickCounter;
    }
     
    public void onClick()
    {
        cookieCounter = cookieCounter + 1 + up.amountOfUpgrades;
        clickCounter++;

    }
    

}

