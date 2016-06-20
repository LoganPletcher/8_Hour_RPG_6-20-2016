using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    Transform StartButton, HelpButton, ExitButton, HelpText, ReturnButton;

	// Use this for initialization
	void Start ()
    {
        foreach(Transform canvasitem in this.gameObject.GetComponentsInChildren<Transform>())
        {
            if (canvasitem.gameObject.name == "StartGameB")
                StartButton = canvasitem;
            else if (canvasitem.gameObject.name == "HtPButton")
                HelpButton = canvasitem;
            else if (canvasitem.gameObject.name == "ExitButton")
                ExitButton = canvasitem;
            else if (canvasitem.gameObject.name == "HowToPlayInstructions")
                HelpText = canvasitem;
            else if (canvasitem.gameObject.name == "ReturnButton")
                ReturnButton = canvasitem;
        }
        StartButton.gameObject.SetActive(true);
        HelpButton.gameObject.SetActive(true);
        ExitButton.gameObject.SetActive(true);
        HelpText.gameObject.SetActive(false);
        ReturnButton.gameObject.SetActive(false);
    }

    public void StartGame(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void ShowInstructions()
    {
        StartButton.gameObject.SetActive(false);
        HelpButton.gameObject.SetActive(false);
        ExitButton.gameObject.SetActive(false);
        HelpText.gameObject.SetActive(true);
        ReturnButton.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Return()
    {
        StartButton.gameObject.SetActive(true);
        HelpButton.gameObject.SetActive(true);
        ExitButton.gameObject.SetActive(true);
        HelpText.gameObject.SetActive(false);
        ReturnButton.gameObject.SetActive(false);
    }
}
