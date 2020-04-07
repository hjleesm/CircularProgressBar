using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialProgress : MonoBehaviour
{
    public Text ProgressIndicator;
    public Image LoadingBar;
    float currentValue;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentValue < 100)
        {
            currentValue += speed * Time.deltaTime;
            ProgressIndicator.text = ((int)currentValue).ToString() + "%";
        }
        else
        {
            ProgressIndicator.text = "Done";
        }

        LoadingBar.fillAmount = currentValue / 100;
    }
}
