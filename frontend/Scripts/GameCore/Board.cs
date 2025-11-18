using Godot;
using System;

public class Board
{
    public ICell[,] Cells = new ICell[3, 3];
    public CellState State { get; private set; } = CellState.Empty;

    public bool IsPlayable => State == CellState.Empty && !IsFull();

    public bool IsFull()
    {
        foreach (var cell in Cells)
        {
            if (cell.IsPlayable)
                return false;
        }
        return true;
    }

    public void MakeMove(Move move, CellState playerState)
    {
        if (!Cells[move.X, move.Y].IsPlayable)
            throw new InvalidOperationException("Cell is not playable.");
        
        if (Cells[move.X, move.Y] is TerminalCell terminalCell)
        {
            terminalCell.SetState(playerState);
        }
        else if (Cells[move.X, move.Y] is BoardCell boardCell)
        {
            boardCell.Board.MakeMove(move.SubMove, playerState);
        }

        UpdateState(playerState);
    }

    public void UpdateState(CellState playerState)
    {
        if (HasLine(playerState))
        {
            State = playerState;
        }
        else if (IsFull())
        {
            State = CellState.Full;
        }
    }

    public bool HasLine(CellState playerState)
    {
        // Check rows and columns
        for (int i = 0; i < 3; i++)
        {
            if (Cells[i, 0].State == playerState && Cells[i, 1].State == playerState && Cells[i, 2].State == playerState)
                return true;
            if (Cells[0, i].State == playerState && Cells[1, i].State == playerState && Cells[2, i].State == playerState)
                return true;
        }

        // Check diagonals
        if (Cells[0, 0].State == playerState && Cells[1, 1].State == playerState && Cells[2, 2].State == playerState)
            return true;
        if (Cells[0, 2].State == playerState && Cells[1, 1].State == playerState && Cells[2, 0].State == playerState)
            return true;

        return false;
    }
}