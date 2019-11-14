using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ennemyscript : MonoBehaviour
{
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Perdu");
            SceneManager.LoadScene(1);
        }
        else if(other.name == "Down")
        {
            score++;
            this.transform.position = new Vector3(Random.Range(-7.8f, 7.8f), 6.75f, this.transform.position.z);
        }
    }
}
