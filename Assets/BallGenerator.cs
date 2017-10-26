using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour {

    public GameObject BallPrefab;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Ball =
                Instantiate(BallPrefab) as GameObject;
            Ball.GetComponent<BallController>().Shoot(
                new Vector3(0, 0, 50.0f));
        }
	}
}
