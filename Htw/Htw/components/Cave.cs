using System;
using wumpus.common;
using System.IO;

public class Cave
{
    private int[][] cave = new int[5][];
    private String caveName;

    public Cave(String caveName)
    {
        this.caveName = caveName;
        StreamReader s = new StreamReader(caveName);
        String line = s.ReadLine();
        for (int i = 0; line != null; i++)
        {
            StreamReader lineReader = new StreamReader(line);
            for (int j = 0; j < line.Length; j++)
            {
                cave[i][j] = lineReader.Read();
            }
        }
    }

    public int[] getAllConnections(int currentRoom)
    {
        int[] connections = new int[6];
        
        return connections;
    }

    public int getConnectedRoom(int currentRoom, Direction direction)
    {
        switch(direction)
        {
            case Direction.NORTH:

                break;

            case Direction.NORTH_EAST:

                break;

            case Direction.NORTH_WEST:

                break;

            case Direction.SOUTH:

                break;

            case Direction.SOUTH_EAST:

                break;

            case Direction.SOUTH_WEST:

                break;

        }

        return 0;
        }
    
}
