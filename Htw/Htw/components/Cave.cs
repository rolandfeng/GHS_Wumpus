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
        for (int row = 0; line != null; row++)
        {
            StreamReader lineReader = new StreamReader(line);
            for (int column = 0; column < line.Length; column++)
            {
                cave[row][column] = lineReader.Read();
            }
        }
    }

    public int[] getAllConnections(int currentRoom)
    {
        int[] connections = new int[6];
        connections[0] = getConnectedRoom(currentRoom, Direction.NORTH);
        connections[1] = getConnectedRoom(currentRoom, Direction.NORTH_EAST);
        connections[2] = getConnectedRoom(currentRoom, Direction.NORTH_WEST);
        connections[3] = getConnectedRoom(currentRoom, Direction.SOUTH);
        connections[4] = getConnectedRoom(currentRoom, Direction.SOUTH_EAST);
        connections[5] = getConnectedRoom(currentRoom, Direction.SOUTH_WEST);
        return connections;
    }

    public int getConnectedRoom(int currentRoom, Direction direction)
    {
        int roomRow = findRoomLocation(currentRoom)[0];
        int roomColumn = findRoomLocation(currentRoom)[1];

        switch (direction)
        {
            case Direction.NORTH:
                if (roomRow == 0)
                    roomRow = 4;
                return cave[roomRow][roomColumn];

            case Direction.NORTH_EAST:
                if (roomRow == 0)
                    roomRow = 4;
                if (roomColumn == 5)
                    roomColumn = 0;
                return cave[roomRow][roomColumn];

            case Direction.NORTH_WEST:
                if (roomRow == 0)
                    roomRow = 4;
                if (roomColumn == 0)
                    roomColumn = 5;
                return cave[roomRow][roomColumn];

            case Direction.SOUTH:
                if (roomRow == 4)
                    roomRow = 0;
                return cave[roomRow][roomColumn];

            case Direction.SOUTH_EAST:
                if (roomRow == 4)
                    roomRow = 0;
                if (roomColumn == 5)
                    roomColumn = 0;
                return cave[roomRow][roomColumn];

            case Direction.SOUTH_WEST:
                if (roomRow == 4)
                    roomRow = 0;
                if (roomColumn == 0)
                    roomColumn = 5;
                return cave[roomRow][roomColumn];
        }

        return 0;
    }

    public void generateRandomCave()
    {

    }

    private int[] findRoomLocation(int roomNum)
    {
        int[] roomLocation = new int[2];
        for (int row = 0; row < cave.Length; row++)
        {
            for (int column = 0; column < cave[row].Length; column++)
            {
                if (cave[row][column] == roomNum)
                {
                    roomLocation[0] = row;
                    roomLocation[1] = column;
                }
            }
        }
        return roomLocation;
    }
}
