using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseBoard : MonoBehaviour {

    bool flag=false;
    void Start () {
    }

	void Update () {
        //Debug.Log(transform.eulerAngles.z);

        if (flag)
        {
            transform.Rotate(new Vector3(0, 0, (180 - transform.eulerAngles.z) * 0.05f));
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, (0 - transform.eulerAngles.z) * 0.05f));
        }
    }

    public void SetFlag ()
    {
        flag = !flag;

    }
}
