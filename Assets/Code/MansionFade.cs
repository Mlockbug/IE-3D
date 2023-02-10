using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MansionFade : MonoBehaviour
{
	bool m_fadingOut = false;
	bool mustFade = false;
	public RawImage m_fade;
	GameObject player;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (mustFade)
		{
			//Debug.Log("FTDAS");
			m_fade.enabled = true;
			player.GetComponent<CharacterControl>().inDialogue = true;
			Color m_fadeColor = m_fade.color;
			if (m_fade.color.a < 1 && m_fadingOut == false)
			{
				m_fadeColor.a += 0.005f;
			}
			else if (m_fade.color.a > 0)
			{
				player.GetComponent<Collider>().enabled = false;
				if (this.gameObject.tag == "MansionChange")
				{
					player.GetComponent<Rigidbody>().velocity = Vector3.zero;
					player.transform.position = GameObject.Find("Mansion Spawn").transform.position;
					player.transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
					player.GetComponent<CharacterControl>().rotation = 180f;
				}
				else if(this.gameObject.tag == "TownChange")
				{
					player.transform.position = GameObject.Find("Town Spawn").transform.position;
					player.GetComponent<CharacterControl>().rotation = GameObject.Find("Town Spawn").transform.rotation.y - 90f;
					player.GetComponent<CharacterControl>().camRotation = GameObject.Find("Town Spawn").transform.rotation.x;
					player.transform.rotation = Quaternion.Euler(new Vector3(0f, player.GetComponent<CharacterControl>().rotation, 0f));
					player.GetComponent<CharacterControl>().cam.transform.localRotation = Quaternion.Euler(new Vector3(player.GetComponent<CharacterControl>().camRotation, 0f, 0f));
				}
				m_fadingOut = true;
				m_fadeColor.a -= 0.005f;
			}
			else
			{
				player.GetComponent<CharacterControl>().inDialogue = false;
				player.GetComponent<Collider>().enabled = true;
				mustFade = false;
				m_fade.enabled = false;
				m_fadingOut = false;
			}
			m_fadeColor.a = Mathf.Clamp(m_fadeColor.a, 0f, 1f);
			m_fade.color = m_fadeColor;
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			player = other.gameObject;
			mustFade = true;
		}
	}
}
