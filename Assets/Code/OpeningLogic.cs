using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningLogic : MonoBehaviour
{
    public GameObject[] cutscenePanels;
    public RawImage fade;
    public GameObject game;
    public GameObject backupCam;
    int counter = 0;
    bool inCutscene = true;
    bool fadingOut = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
            }
        }
        else
        {
            Color fadeColor = fade.color;
            if (fade.color.a < 1 && fadingOut == false)
            {
                fadeColor.a += 0.005f;
            }
			else if (fade.color.a >= 0)
			{
				cutscenePanels[counter - 1].SetActive(false);
				fadingOut = true;
				fadeColor.a -= 0.005f;
				game.SetActive(true);
			}
			fadeColor.a = Mathf.Clamp(fadeColor.a,0f,1f);
            fade.color = fadeColor;
			if (fadingOut && fade.color.a <= 0)
            {
                fade.enabled = false;
                backupCam.SetActive(false);
				Destroy(this.gameObject);
            }
            //Debug.Log(fadeColor.a);
		}
    }
}
