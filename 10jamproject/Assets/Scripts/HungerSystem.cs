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


    void Start()
    {
        currentHunger = 50/maxHunger;
    }

    // Update is called once per frame
    void Update()
    {
        hungerImg.fillAmount = currentHunger;
       if ( currentHunger > 0)
        {
            StartCoroutine(HungerDegen());

        }
    }
    private IEnumerator HungerDegen()
    {
        yield return new WaitForSeconds(2);

        while (currentHunger > 0)
        {
            currentHunger -= 5 * Time.deltaTime;
            hungerImg.fillAmount = currentHunger;
            yield return degenTick;
        }
    }
}
