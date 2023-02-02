using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelLogic : MonoBehaviour
{

    //gonna reuse this for the table for a bit as well cause it should work as a simple option before i start to properly bug test it

    public bool pickedUp = false;
    bool respawn = false;
    Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickedUp)
		{
            StopAllCoroutines();
            StartCoroutine(countdownLong());
            pickedUp = false;
		}

        if (respawn)
		{
            Debug.Log("P");
            FindObjectOfType<CharacterControl>().PickupAndDrop(0f);
            transform.position = spawnPos;
            respawn = false;
        }
    }

    //was probably over complicating this, so I commented it out

    /*private void OnTriggerExit(Collider other)
	{
		if (other.tag == "pipe")
		{
            Debug.Log("M");
            StopAllCoroutines();
            StartCoroutine(countdownShort());
        }
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "pipe")
        {
            Debug.Log("N");
            StopCoroutine(countdownShort());
        }
    }*/

    ////use time.deltatime for countdownLong, stop all in stay
    IEnumerator countdownLong()
	{
        Debug.Log("I");
        yield return new WaitForSeconds(300);
        respawn = true;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "respawnB")
        {
            respawn = true;
        }
	}

	/*IEnumerator countdownShort()
    {
        Debug.Log("J");
        yield return new WaitForSeconds(5);
        respawn = true;
    }*/
}
