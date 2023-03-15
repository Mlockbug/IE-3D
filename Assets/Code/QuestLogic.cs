using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLogic : MonoBehaviour
{
    Collider ThingInCollision;
    int barrelCount;
    bool table;
    int fencePosts;
    Vector3[] fencePositions = new Vector3[4] {new Vector3(-585.7552f, 53.06111f, -61.10086f), new Vector3(-586.39f, 53.06111f, -60.14f), new Vector3(-588.44f, 46.64f, -57.86f), new Vector3(-587.84f, 46.64f, -58.78f)};
    float fenceRotation = 51.624f;
    bool[] positionChecks = new bool[4] {false,false,false,false};
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
        if (fencePosts == 4)
		{
            GameObject.Find("Quest Manager").GetComponent<QuestManager>().ActivateQuests("12", null);
            fencePosts = 0;
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
            
            FindObjectOfType<CharacterControl>().PoemExtention(Random.Range(1, 3));
            switch (other.tag)
            {
                case "barrel":
                    barrelCount++;
					Destroy(ThingInCollision.gameObject);
					break;
                case "table":
                    table= true;
					Destroy(ThingInCollision.gameObject);
					break;
                case "fence":
					ThingInCollision.attachedRigidbody.useGravity= false;
                    ThingInCollision.attachedRigidbody.velocity= Vector3.zero;
					Destroy(ThingInCollision.GetComponent<BoxCollider>());
					Destroy(ThingInCollision.GetComponent<Rigidbody>());
					Destroy(ThingInCollision.GetComponent<BarrelLogic>());
					other.transform.localPosition = fencePositions[fencePosts];
					other.transform.rotation = Quaternion.Euler(0f,fenceRotation,0f);
					fencePosts++;
                    break;
            }
        }
    }
}
