using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLogic : MonoBehaviour
{
    Collider ThingInCollision;
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
        ThingInCollision = other;
        if (other.tag == tag)
		{
            if (ThingInCollision.attachedRigidbody.useGravity == false)
            {
                FindObjectOfType<CharacterControl>().PickupAndDrop(0f);
            }
            Destroy(ThingInCollision.gameObject);
            FindObjectOfType<CharacterControl>().PoemExtention(Random.Range(2, 4));
        }
    }
}
