using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    Tile tile1;
    Tile tile2; 
    int tilecount=0;
   public Tile[] tiles;
   public string level;

    // Start is called before the first frame update
    void Start()
    {
        Shuffle();
    }

    void Shuffle()
    {
        for (int i = 0; i < 100; i++)
        {
            int r1=Random.Range(0,tiles.Length);
            int r2=Random.Range(0,tiles.Length);
            Vector3 temp = tiles[r1].transform.position;
            
            tiles[r1].transform.position=tiles[r2].transform.position;
            tiles[r2].transform.position=temp;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TileClicked(Tile SelectedTile){

        tilecount += 1;
        if (tilecount==1)
        {
            tile1=SelectedTile; 
        }
        if(tilecount==2)
        {
            tile2=SelectedTile;
            SwapTiles();
            if (InOrder()==true)
            {
                print("solved");
                SceneManager.LoadScene(level);
            }
        }
    }

    bool InOrder()
    {
        bool ordered=true;
        for (int i = 0; i < tiles.Length; i++)
        {
            if (tiles[i].transform.position != tiles[i].Position())
            {
                ordered=false;
            }
        }
        return ordered; 
    }

    void SwapTiles(){
        Vector3 temp =tile2.transform.position;
        tile2.transform.position=tile1.transform.position;
        tile1.transform.position=temp;
        tilecount=0;
    }
}
