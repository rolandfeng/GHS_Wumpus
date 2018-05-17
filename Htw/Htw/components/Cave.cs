using System;
using wumpus.common;
using System.IO;
using System.Collections;

public class Cave
{
    private int[][] cave = new int[5][];
    private String caveName;

    // Creates a 2D array by reading in from the given file
    public Cave(String caveName)
    {
        this.caveName = caveName;
        string[] lines = File.ReadAllLines(caveName);

        for(int row = 0; row < lines.Length; row++)
        {
            
            String line = lines[row];
            string[] segments = line.Split(';');
            cave[row] = new int[segments.Length];
            for (int column = 0; column < segments.Length; column++)
            {
                cave[row][column] = Int32.Parse(segments[column]);
            }
       
        }
    }

    // Calls get connected room for all directions, adds all the room numbers
    // to an array and returns that array. 0 will be returned for walls
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

    // Finds all rooms connected to first room, if second room is one of them will return
    // true. Returns false if not adjacent
    public Boolean isAdjacent(int room1, int room2)
    {
        int[] connections = getAllConnections(room1);
        for (int i = 0; i < connections.Length; i++)
        {
            if (connections[i] == room2)
                return true;
        }
        return false;
    }

    // Finds and returns the room adjacent to the given room based on the given direction
    // Returns 0 if a wall
    public int getConnectedRoom(int currentRoom, Direction direction)
    {
        int[] roomLoc = findRoomLocation(currentRoom);
        int roomRow = roomLoc[0];
        int roomColumn = roomLoc[1] - numZerosBeforeIndex(roomLoc[0], roomLoc[1]); 
        // Column offset to compensate for walls

        switch (direction)
        {
            case Direction.NORTH:
                if (roomRow == 0)
                    roomRow = 5;
                return cave[roomRow - 1]
                           [roomColumn - numZerosBeforeIndex(roomRow - 1, roomColumn)];

            case Direction.NORTH_EAST:
                if (roomRow == 0)
                    roomRow = 5;
                if (roomColumn == 5)
                    roomColumn = -1;
                return cave[roomRow - 1]
                           [roomColumn - numZerosBeforeIndex(roomRow - 1, roomColumn) + 1];

            case Direction.NORTH_WEST:
                if (roomRow == 0)
                    roomRow = 5;
                if (roomColumn == 0)
                    roomColumn = 6;
                return cave[roomRow - 1]
                           [roomColumn - numZerosBeforeIndex(roomRow - 1, roomColumn) - 1];

            case Direction.SOUTH:
                if (roomRow == cave.Length - 1)
                    roomRow = -1;
                return cave[roomRow + 1]
                           [roomColumn - numZerosBeforeIndex(roomRow + 1, roomColumn)];

            case Direction.SOUTH_EAST:
                if (roomRow == cave.Length - 1)
                    roomRow = -1;
                if (roomColumn == 5)
                    roomColumn = -1;
                return cave[roomRow + 1]
                           [roomColumn - numZerosBeforeIndex(roomRow + 1, roomColumn) + 1];

            case Direction.SOUTH_WEST:
                if (roomRow == cave.Length - 1)
                    roomRow = -1;
                if (roomColumn == 0)
                    roomColumn = 6;
                return cave[roomRow + 1]
                           [roomColumn - numZerosBeforeIndex(roomRow + 1, roomColumn) - 1];
        }

        return 0;
    }

    public void generateRandomCave(String filename)
    {
        String[] linesArray = new String[cave.Length];
        ArrayList numList = new ArrayList();
        for (int i = 1; i <= 30; i++)
        {
            numList.Add(i);
        }
        Random randNum = new Random();
        for (int i = 0; i < linesArray.Length; i++)
        {
            int locOf0 = randNum.Next(0, cave.Length + 1);
            for (int j = 0; j < cave.Length + 1; j++)
            {
                if (j == locOf0)
                    if (j == cave.Length)
                        linesArray[i] += "" + 0;
                    else
                        linesArray[i] += "" + 0 + ";" ;
                else
                {
                    int num = randNum.Next(0, numList.Count);
                    if (j == cave.Length)
                        linesArray[i] += "" + numList[num];
                    else
                        linesArray[i] += "" + numList[num] + ";";
                    numList.RemoveAt(num);
                }
            }
        }
        File.WriteAllLines(filename, linesArray);
    }

    // Searches cave for the given room and returns array of row and column location
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

    // Returns the number of zeros found in the given row before the given column
    private int numZerosBeforeIndex(int row, int column)
    {
        int count = 0;
        for (int i = 0; i < column; i++)
        {
            if (cave[row][i] > 0)
            {
                count++;
            }
        }
        return count;
    }
}