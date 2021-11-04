using System;

namespace EnemyAi
{
    class Program
    {

        static void Main(string[] args)
        {

        }
    }

    class Room
    {
        int[][] Tile = new int[2][];

        public void Doit()
        {
            for (int y = 0; y < Tile.Length; y++)
            {
                Tile[y] = new int[5];
            }
        }
    } 


}
