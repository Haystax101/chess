using System;

public class ChessBoard
{
	private Piece[,] board;

	public ChessBoard()
	{
		board = new Piece[8, 8];
		board[0, 0] = new Rook(Color.Black);
	}

	public Piece GetPieceAtPosition(int row, int col)
	{
		return board[row, col];
	}

	public void SetPieceAtPosition(int row, int col, Piece piece)
	{
		board[row, col] = piece;
	}

	public void PrintBoard()
	{
		for (int row=0; row<8; row++)
		{
			for(int col=0; col<8; col++)
			{
				Piece piece = GetPieceAtPosition(row, col);
				string pieceSymbol = piece != null ? piece.GetSymbol() : ".";
				Console.Write(pieceSymbol + " ");
			}
			Console.WriteLine();
		}
	}
}

/* Create an abstract base class that provides a 'Color' property and an abstract 'IsValidMove' method,
 * which subclasses will implement to determine if a given move is valid for that piece. */
// Will need to define subclasses for each type of chess piece which implement "IsValidMove" differently depending on that piece.

public abstract class Piece
{
	public Color Color { get; private set; }

	public Piece(Color color)
	{
		Color = color;
	}

	public abstract bool IsValidMove(int fromRow, int fromCol, int toRow, int toCol);
}

public enum Color
{
	White,
	Black
}

public class Pawn : Piece
{
	public Pawn(Color color) : base(color)
	{

	}

    public override bool IsValidMove(int fromRow, int fromCol, int toRow, int toCol)
    {
		// Check if the move is one or two squares forward
		int direction = Color == Color.White ? -1 : 1;
		int deltaRow = toRow - fromRow;
		int deltaCol = toCol - fromCol;
		if (deltaCol != 0) // pawns can only move forward along the same column.
		{
			return false;
		}
		if (deltaRow == direction || (deltaRow == 2 * direction && fromRow == (Color == Color.White ? 6 : 1)))
		{
			return true;
		}
		return false;
    }

	public override string GetSymbol()
	{
		return Color == Color.White ? "P", "p";
	}
}

public class Rook : Piece
{
	public Rook(Color color) : base(color)
	{

	}
	
	public override bool IsValidMove(int fromRow, int fromCol, int toRow, int toCol)
	{
		// Check if move is vertical or horizontal
		if (fromRow != toRow && fromCol != toCol)
		{
			return false;
		}

		// Check if path is clear
		int rowStep = fromRow == toRow ? 0 : (fromRow < toRow ? 1 : -1);
		int colStep = fromCol == toCol ? 0 : (fromCol < toCol ? 1 : -1);
		int row = 
	}
}	
