﻿using System;
using wumpus.common;
using System.IO;
using System.Collections;

public class Cave
{
    private int[][] cave = new int[30][];
    private String caveName;

    // Creates a 2D array by reading in from the given file
    public Cave(String caveName)
    {
        this.caveName = caveName;
        if (File.Exists(caveName))
        {
            fillCave();
        }
        else
        {
            this.caveName = "CaveStarter.txt";
            fillCave();
            randomizeConnections();
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
        switch (direction)
        {
            case Direction.NORTH:
                if (cave[currentRoom - 1][1] < 0)
                    return 0;
                return cave[currentRoom - 1][1];
                
            case Direction.NORTH_EAST:
                if (cave[currentRoom - 1][2] < 0)
                    return 0;
                return cave[currentRoom - 1][2];

            case Direction.NORTH_WEST:
                if (cave[currentRoom - 1][3] < 0)
                    return 0;
                return cave[currentRoom - 1][3];

            case Direction.SOUTH:
                if (cave[currentRoom - 1][4] < 0)
                    return 0;
                return cave[currentRoom - 1][4];

            case Direction.SOUTH_EAST:
                if (cave[currentRoom - 1][5] < 0)
                    return 0;
                return cave[currentRoom - 1][5];

            case Direction.SOUTH_WEST:
                if (cave[currentRoom - 1][6] < 0)
                    return 0;
                return cave[currentRoom - 1][6];

        }
        return 0;
    }

    // Goes through the cave and randomly places at least 3 walls for each room
    private void randomizeConnections()
    {
        Random random = new Random();
        ArrayList rowList = new ArrayList();
        for (int z = 0; z < cave.Length; z++)
        {
            rowList.Add(z);
        }
        for (int rowNum = 0; rowNum < cave.Length; rowNum++)
        {
            // Choosing 3 random locations for walls
            ArrayList list = new ArrayList();
            for (int i = 1; i <= 6; i++)
                list.Add(i);
            int[] locs = new int[3];
            int num;
            for (int j = 0; j < 3; j++)
            {
                num = random.Next(0, list.Count);
                locs[j] = (int)list[num];
                list.RemoveAt(num);
            }

            int row = (int) rowList[random.Next(0, rowList.Count)];
            for (int column = 1; column < cave[row].Length; column++)
            {
                if (column == locs[0] || column == locs[1] || column == locs[2])
                    for (int k = 0; k < cave[0].Length; k++)
                    {
                        // adding corresponding wall (to avoid 1-way connections)
                        if (cave[Math.Abs(cave[row][column]) - 1][k] == cave[row][0])
                              cave[Math.Abs(cave[row][column]) - 1][k] = - cave[Math.Abs(cave[row][column]) - 1][k];
                    }
                    cave[row][column] = -cave[row][column];
            }
        }
    }

    // Takes all numbers from given file and reads them into the cave array
    private void fillCave()
    {
        string[] lines = File.ReadAllLines(caveName);
        for (int row = 0; row < lines.Length; row++)
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
}