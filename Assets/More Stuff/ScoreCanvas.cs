using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCanvas : MonoBehaviour {
    public Camera cam;
    public PlayerMovement player;
    private Text txtfield;
    private int score = 0;

    void Awake()
    {
        txtfield = GetComponent<Text>();
    }
	// Use this for initialization
	void Start () {
        if (cam == null)
        {
            cam = Camera.main;
        }
        if (cam != null)
        {
            transform.SetParent(cam.GetComponent<Transform>(), true);
        }
	}
	
	// Update is called once per frame
	void LateUpdate () {
        score = player.getScore();
        txtfield.text = "Score: " + score.ToString();
	}

}
