using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class quitMenuScript : MonoBehaviour {

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;

	// Use this for initialization
	void Start () {

        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;

    }
	
	public void ExitPress()
    {
        quitMenu.enabled = true;
        exitText.enabled = false;
        startText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        exitText.enabled = true;
        startText.enabled = true;
    }

    public void StartLvl()
    {
        SceneManager.LoadScene("screamit_main");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
