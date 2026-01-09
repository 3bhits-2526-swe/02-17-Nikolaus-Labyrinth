/*
    This script uses the maze obj to handle each and every event happening on it

    @author: wek56ur@gmail.com
    @date: 2025-12-17

*/
using UnityEngine; 

public class EventManager
{
    [SerializeField] int width; 
    [SerializeField] int length; 
    /*  -> array of tiles 
        tile: 
            int x, 
            int y, 
            attributes {
                hasGift, hasLP, isWall, isBroken
            }

    -> has access to each type of tile 
    stores array with data 
    */

    class Tile
    {
        int posX; //= width 
        int posY; //= length 
        mod attribute; 

        public Tile(int x, int y)
        {
            this.posX = x; 
            this.posY = y; 
            this.attribute = mod.none; 
        }

        void setMod(mod m)
        {
            this.attribute = m; 
        }
 
        public enum mod
        {
            //attr
            none, hasGift, hasLP,
            //prop
            isBroken, isWall
        }
        public enum Material
        {
            //list of diff looks for the tiles 
            tex1,tex2,tex3,tex4,tex5
        }

    }

    [SerializeField] int aggressiveness; //scales timing

    //option to spawn new scene
    //option to spawn new scene2

    //array with good coords of maze


    void Start()
    {
        //init tile array + textures + gen maze 
    }

    void Update()
    {
        //check for events and such 
    }

    void FixedUpdate()
    {
        //check for conds to activate events 
    }
}