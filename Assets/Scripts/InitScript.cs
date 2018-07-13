using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitScript : MonoBehaviour {

    public int N = 10;
    public Transform tile;

	// Use this for initialization
	void Start () {
        
        Transform redBase = GameObject.Find("RedGround").transform;
        Vector3 scale = redBase.transform.localScale;
        //꼭짓점 위치 구함
        Vector3 offsetPosition = new Vector3(-0.5f, 0.5f, -0.5f);

        float O;
        O = 1.0f/N;
        offsetPosition.x += O/2;
        offsetPosition.y -= O/2;
        offsetPosition.z += O/2;

        tile = Resources.Load<Transform>("Prefabs/Tile");
        //Instantiate(tile, null).position = v2;

        
        for(int i=0; i<N; ++i)
        {
            for(int j=0; j<N; ++j)
            {
                Transform g=Instantiate(tile,redBase);
                g.localPosition = offsetPosition;
                g.localPosition += new Vector3(i*O, O/2, j *O);
                g.transform.localScale = new Vector3(1.05f, 0.105f, 1.05f);
                g.transform.localScale /= N;
            }
        }

        Transform blueBase = GameObject.Find("BlueGround").transform;
        scale = blueBase.transform.localScale;
        //꼭짓점 위치 구함
        offsetPosition = new Vector3(-0.5f, 0.5f, -0.5f);

        O = 1.0f / N;
        offsetPosition.x += O / 2;
        offsetPosition.y -= O / 2;
        offsetPosition.z += O / 2;

        for (int i = 0; i < N; ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                Transform g = Instantiate(tile, blueBase);
                g.localPosition = offsetPosition;
                g.localPosition += new Vector3(i * O, O/2, j * O);
                g.transform.localScale = new Vector3(1.05f, 0.105f, 1.05f);
                g.transform.localScale /= N;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
