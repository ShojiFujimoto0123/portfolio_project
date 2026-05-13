using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Boot : MonoBehaviour
{
    [SerializeField] public Button _gotoAdvButton;


    void Start()
    {
		Debug.Log("Starting Boot");

		_gotoAdvButton.onClick.AddListener(() => { 
			Debug.Log("on button clicked");
			SceneManager.LoadScene("ADV");
		});


	}
}
