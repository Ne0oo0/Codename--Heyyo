using UnityEngine;
using System.Collections;

public class LightBlink : MonoBehaviour
{
    private Animation anim;

    int times = 4;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        StartCoroutine(LightBlinkTime());
        Debug.Log("testing");

    }


    IEnumerator LightBlinkTime()
    {
        yield return new WaitForSeconds(2f);

        while (times > 0) 
        {
            if (times <= 2)
            {
                while (times > 0)
                {
                    anim.Play("New Animation2");
                    times--;
                    yield return new WaitForSeconds(6f);
                }

            }
            else 
            {
                anim.Play("New Animation");
                times--;
                yield return new WaitForSeconds(6f);

            }
            
        }
    }
}
