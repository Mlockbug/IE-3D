using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelQuest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "barrel")
		{
            if (other.attachedRigidbody.useGravity == false)
			{
                FindObjectOfType<CharacterControl>().PickupAndDrop(0f);
			}
            Destroy(other.gameObject);
            FindObjectOfType<CharacterControl>().PoemExtention(Random.Range(3,5));
		}
	}
}
