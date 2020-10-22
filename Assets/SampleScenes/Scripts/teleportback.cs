using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class teleportback : MonoBehaviour
{



    public string level;
    private void OnCollisionEnter(Collision collision)




    {
        SceneManager.LoadScene(level);
        
    }




}
        
    

