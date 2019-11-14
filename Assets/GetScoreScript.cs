using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text = "Score : " + ennemyscript.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
