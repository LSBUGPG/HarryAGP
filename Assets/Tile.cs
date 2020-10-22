using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    Vector3 StartingPosition;
    public GameManager Game; 
    // Start is called before the first frame update
    void Awake()
    {
        StartingPosition.x=transform.position.x;
        StartingPosition.y=transform.position.y;
        StartingPosition.z=transform.position.z;
    }

    public Vector3 Position ()
    {
        return StartingPosition; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp (){
        Game.TileClicked(this);
    }
}
