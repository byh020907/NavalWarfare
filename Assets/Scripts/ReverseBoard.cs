using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseBoard : MonoBehaviour {
    
    void Start () {
    }

	void Update () {
        Debug.Log(transform.eulerAngles.z);
        transform.Rotate(new Vector3(0,0, (180-transform.eulerAngles.z)*0.05f));
    }
}
