using LemonedgeTest;

Phone pad = new Phone();
int numberCount = 7;


Piece pawn = PieceFactory.MakePiece(pad.keypad, "Pawn", numberCount);
Console.WriteLine("Pawn count is " + pawn.count);
Piece rook = PieceFactory.MakePiece(pad.keypad, "Rook", numberCount);
Console.WriteLine("Rook count is " + rook.count);
Piece bishop = PieceFactory.MakePiece(pad.keypad, "Bishop", numberCount);
Console.WriteLine("Bishop count is " + bishop.count);
Piece knight = PieceFactory.MakePiece(pad.keypad, "Knight", numberCount);
Console.WriteLine("Knight count is " + knight.count);
Piece king = PieceFactory.MakePiece(pad.keypad, "King", numberCount);
Console.WriteLine("King count is " + king.count);
Piece queen = PieceFactory.MakePiece(pad.keypad, "Queen", numberCount);
Console.WriteLine("Queen count is " + queen.count);

Console.ReadLine();