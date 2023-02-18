using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLogic : MonoBehaviour
{
    Collider ThingInCollision;
    int barrelCount;
    bool table;
    int fencePosts;
    Vector3[] fencePositions = new Vector3[4] {new Vector3(-419.76f, 31f, -19.94f), new Vector3(-420.38f, 31f, -19.16f), new Vector3(-421.57f, 24.587f, -17.66f), new Vector3(-422.23f, 24.587f, -16.83f) };
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
            Destroy(ThingInCollision.gameObject);
            FindObjectOfType<CharacterControl>().PoemExtention(Random.Range(1, 3));
            switch (other.tag)
            {
                case "barrel":
                    barrelCount++;
                    break;
                case "table":
                    table= true; 
                    break;
                case "fence":
                    other.transform.localPosition = fencePositions[fencePosts];
					other.transform.rotation = Quaternion.Euler(0f,fenceRotation,0f);
					fencePosts++;
                    break;
            }
        }
    }
}
