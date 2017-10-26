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

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Ball.GetComponent<BallController>().Shoot(
                worldDir.normalized * 2000);
        }
	}
    private void OnCollisionEnter(Collision other)
    {
        Destroy(this.gameObject);
    }
}
