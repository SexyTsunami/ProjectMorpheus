using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour {

    public Text startGameButton;
    public GameObject menuScreen;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void StartGame() {
        menuScreen.SetActive(false);
    }
}
