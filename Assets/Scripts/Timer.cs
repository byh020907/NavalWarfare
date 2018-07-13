using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int maxCount =20;
    public Text text;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ss()
    {
        StartCoroutine("StartTimer");
    }

    public IEnumerator StartTimer()
    {
        for (int i = maxCount; i >= 0; --i)
        {
            text.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
    }
}
