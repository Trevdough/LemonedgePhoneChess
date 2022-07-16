using LemonedgeTest;

Phone pad = new Phone();
int numberLength = 7;

Game thePawnGame = new Game(pad.keypad, "Pawn", numberLength);
Console.WriteLine("Pawn has a count of: " + thePawnGame.validNumberCount);
Game theRookGame = new Game(pad.keypad, "Rook", numberLength);
Console.WriteLine("Rook has a count of: " + theRookGame.validNumberCount);
Game theBishopGame = new Game(pad.keypad, "Bishop", numberLength);
Console.WriteLine("Bishop has a count of: " + theBishopGame.validNumberCount);
Game theKnightGame = new Game(pad.keypad, "Knight", numberLength);
Console.WriteLine("Knight has a count of: " + theKnightGame.validNumberCount);
Game theKingGame = new Game(pad.keypad, "King", numberLength);
Console.WriteLine("King has a count of: " + theKingGame.validNumberCount);
Game theQueenGame = new Game(pad.keypad, "Queen", numberLength);
Console.WriteLine("Queen has a count of: " + theQueenGame.validNumberCount);



Console.ReadLine();