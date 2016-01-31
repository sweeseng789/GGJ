using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuSoundScript : MonoBehaviour {

	public Canvas QuitMenu;
	public Canvas Credits;
	public Button GameStart;
	public Button CreditsButton;
	public Button QuitText;
	// Sound Effects
	public AudioClip Sound;
	private AudioSource enter16;
	private AudioSource cancel7;

	// Use this for initialization
	void Start ()
	{
		QuitMenu = QuitMenu.GetComponent<Canvas> ();
		Credits = Credits.GetComponent<Canvas> ();
		GameStart = GameStart.GetComponent<Button> ();
		CreditsButton = CreditsButton.GetComponent<Button> ();
		QuitText = QuitText.GetComponent<Button> (); 
		QuitMenu.enabled = false;
		Credits.enabled = false;
	}
	void Awake () {
		cancel7 = GetComponent<AudioSource>();
		enter16 = GetComponent<AudioSource>();
	}

	public void QuitPressed()
	{
		QuitMenu.enabled = true;
		Credits.enabled = false;
		CreditsButton.enabled = false;
		GameStart.enabled = false;
		QuitText.enabled = false;
	}
	public void NoButtonpressed()
	{
		QuitMenu.enabled = false;
		Credits.enabled = false;
		GameStart.enabled = true;
		CreditsButton.enabled = true;
		QuitText.enabled = true;
	}
	public void StartLevel()
	{
		//Application.LoadLevel (1);
	}

	public void YesButtonpressed()
	{
		Application.Quit ();
	}
	public void CreditsPressed()
	{
		QuitMenu.enabled = false;
		Credits.enabled = true;
		GameStart.enabled = false;
		CreditsButton.enabled = false;
		QuitText.enabled = false;
	}
		
	// Update is called once per frame
	void Update () {
	
	}
}
