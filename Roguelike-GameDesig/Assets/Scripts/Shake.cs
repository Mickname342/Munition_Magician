using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public bool start = false;
    public AnimationCurve curve;
    public float duration = 0.3f;
    Transform realStartPos;
    public Transform camera2;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        realStartPos = camera2;
    }
    void Update()
    {
        if (start)
        {
            StartCoroutine(Shaking());
            start = false;
        }
        if (!start)
        {
            transform.localPosition = new Vector3(0, 0, -14.24f);
        }
    }

    public void ShakeIt()
    {
        start = true;
    }

    IEnumerator Shaking()
    {
        
        float elapsedTime = 0f;

        while(elapsedTime < duration)
        {
            Vector3 startPos = transform.localPosition;
            elapsedTime += Time.deltaTime;
            float strength = curve.Evaluate((elapsedTime / duration) /2);
            transform.localPosition = startPos + Random.insideUnitSphere;
            yield return null;
        }
        
        
    }
}
