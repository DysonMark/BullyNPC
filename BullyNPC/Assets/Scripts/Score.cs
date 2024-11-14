using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scoreValue = 0;

    public TextMeshProUGUI score;

    [SerializeField] private AudioSource source;

    [SerializeField] private AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scoreValue;

        if (scoreValue == 30 || scoreValue == 60 || scoreValue == 100)
        {
            source.PlayOneShot(clip);
        }
        else
        {
            source.Pause();
        }
    }
}
