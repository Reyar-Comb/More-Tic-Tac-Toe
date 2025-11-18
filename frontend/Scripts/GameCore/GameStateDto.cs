using Godot;
using System;
using System.Collections.Generic;

public class GameStateDto
{
    public int Dimension { get; set; }
    public CellState CurrentPlayer { get; set; }
    public CellState Winner { get; set; }
    public bool IsFinished { get; set; }
    
    public CellState[] Cells { get; set; } = null!;
}