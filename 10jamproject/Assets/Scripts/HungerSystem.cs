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
    private WaitForSeconds degenTick = new WaitForSeconds(20f) ;
    private float degenSpeed =0.01f;
    bool isEating;
    void Start()
    {
        currentHunger = maxHunger/maxHunger;
        
    }

    // Update is called once per frame
    void Update()
    {
        hungerImg.fillAmount = currentHunger;

       if ( currentHunger > 0)
        {
            StartCoroutine(HungerDegen());

        }
      
        /*if (isEating ==false && currentHunger > 0)
       {
            StartCoroutine(HungerDegen());
       }
        else
        {
            StopCoroutine(HungerDegen());
        }
        */
    }
    private IEnumerator HungerDegen()
    {
        yield return new WaitForSeconds(2);

        while (currentHunger > 0)
        {
            currentHunger -= 1 * Time.deltaTime * degenSpeed;
            hungerImg.fillAmount = currentHunger;
            yield return degenTick;
        }
    }
    private void Eating()
    {
        isEating = true; 
    }

}
