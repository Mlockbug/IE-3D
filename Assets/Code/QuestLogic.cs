using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLogic : MonoBehaviour
{
    Collider ThingInCollision;
    int barrelCount;
    bool table;
    int fencePosts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (barrelCount == 5)
        {
            GameObject.Find("Quest Manager").GetComponent<QuestManager>().ActivateQuests("7", null);
            barrelCount= 0;
        }
        if (table)
        {
			GameObject.Find("Quest Manager").GetComponent<QuestManager>().ActivateQuests("9", null);
            table = false;
		}
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
            switch (other.tag)
            {
                case "barrel":
                    barrelCount++;
                    break;
                case "table":
                    table= true; 
                    break;
            }
        }
    }
}
