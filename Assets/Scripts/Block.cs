using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void Start ()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
    }

	// Update is called once per frame
	private void Update ()
    {
        if (transform.position.y < -2f)
            Destroy(gameObject);
	}

}
