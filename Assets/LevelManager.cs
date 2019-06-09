using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public ScoreKeeper ScoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        ScoreKeeper.SetCurrentScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
