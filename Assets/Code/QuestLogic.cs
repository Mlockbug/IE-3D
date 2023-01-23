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

    public void QuestProgress()
	{
        if (ThingInCollision.attachedRigidbody.useGravity == false)
        {
            FindObjectOfType<CharacterControl>().PickupAndDrop(0f);
        }
        Destroy(ThingInCollision.gameObject);
        FindObjectOfType<CharacterControl>().PoemExtention(Random.Range(2, 4));
    }

	private void OnTriggerEnter(Collider other)
	{
        ThingInCollision = other;
        switch (tag)
        {
            case "B-Quest":
                if (other.tag == "barrel")
                {
                    QuestProgress();
                }
                break;
            case "P-Quest":
                if (other.tag == "pipe")
				{
                    QuestProgress();
                }
                break;
        }
    }
}
