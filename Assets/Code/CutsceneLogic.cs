using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class CutsceneLogic : MonoBehaviour
{
    public GameObject[] cutscenePanels;
    public RawImage fade;
    public GameObject game;
    public GameObject backupCam;
    int counter = 0;
    bool inCutscene = true;
    bool fadingOut = false;
    bool mustFade = false;
    bool ending = false;
    public AudioClip poemAudio;
    public AudioSource audioPlayer;
    public GameObject endCutscene;
    bool creditsActive = false;
    bool mustScroll = false;

    public AudioClip[] music;
	public int tempActiveMusic;
	public int activeMusic;
    float volume = 1.0f;

	// Start is called before the first frame update
	void Start()
    {
        audioPlayer= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tempActiveMusic != activeMusic)
        {
            activeMusic = tempActiveMusic;
            MusicChange();
        }
        if (inCutscene)
        {
            foreach (GameObject panel in cutscenePanels)
            {
                panel.SetActive(false);
            }

            cutscenePanels[counter].SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                counter++;
            }

            if (counter >= 6)
            {
                inCutscene = false;
                mustFade = true;
            }
        }
        else if(mustFade)
        {
            Color fadeColor = fade.color;
            if (fade.color.a < 1 && fadingOut == false)
            {
                fadeColor.a += 0.005f;
            }
			else if (fade.color.a >= 0 && !creditsActive)
			{
                if (ending)
                {
                    endCutscene.SetActive(true);
                }
				cutscenePanels[counter - 1].SetActive(false);
				fadingOut = true;
				fadeColor.a -= 0.005f;
				game.SetActive(true);
			}
			else if (fade.color.a >= 0 && creditsActive)
            {
                mustScroll= true;
			}
			fadeColor.a = Mathf.Clamp(fadeColor.a,0f,1f);
            fade.color = fadeColor;
			if (fadingOut && fade.color.a <= 0)
            {
                if(ending)
                {
                    StartCoroutine(EndCutscene());
				}
                fade.enabled = false;
                backupCam.SetActive(false);
				mustFade = false;
                fadingOut= false;
            }
            //Debug.Log(fadeColor.a);
		}

        if (mustScroll && endCutscene.GetComponent<RectTransform>().localPosition.y < 1550)
        {
            endCutscene.GetComponent<Rigidbody>().velocity = Vector3.up * 100;
        }
        else
        {
            if (mustScroll)
            {
				Cursor.lockState = CursorLockMode.Confined;
			}
			endCutscene.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
    }

    public void EndingActive()
    {
		GameObject.Find("Player").GetComponent<CharacterControl>().inDialogue = true;
		mustFade = true;
		fade.enabled = true;
		ending = true;
    }

    IEnumerator EndCutscene() 
    {
		audioPlayer.loop = false;
		audioPlayer.PlayOneShot(poemAudio);
        yield return new WaitForSeconds(47);
        mustFade = true;
        creditsActive= true;
    }

    void MusicChange()
    {
        audioPlayer.loop = true;
        while (volume > 0)
        {
            volume -= 0.03f;
            audioPlayer.volume= volume;
        }
        audioPlayer.clip = music[activeMusic];
        audioPlayer.Play();
		while (volume < 1)
		{
			volume += 0.03f;
			audioPlayer.volume = volume;
		}
	}
}
