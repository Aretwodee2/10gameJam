using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public Image hungerImg;
    float maxHunger = 100f;
    public float currentHunger;
    void Start()
    {
        currentHunger = 50/maxHunger;
    }

    // Update is called once per frame
    void Update()
    {
        hungerImg.fillAmount = currentHunger;
       
    }
}
