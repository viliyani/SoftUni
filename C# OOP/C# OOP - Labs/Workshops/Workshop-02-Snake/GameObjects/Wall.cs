using System;
using System.Collections.Generic;

namespace SnakeWorkshop.GameObjects
{
    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';

        private int playerPoints;

        public Wall(int leftX, int topY)
            : base(leftX, topY)
        {
            InitializeWallBorders();
            PlayerInfo();
        }

        public void AddPoints(Queue<Point> snakeElements)
        {
            this.playerPoints = snakeElements.Count - 6;
        }

        public void PlayerInfo()
        {
            Console.SetCursorPosition(this.LeftX + 3, 0);
            Console.Write($"Player points: {this.playerPoints}");

            Console.SetCursorPosition(this.LeftX + 3, 1);
            Console.Write($"Player level: {this.playerPoints / 10}");
        }

        public bool IsPointOfWall(Point snake)
        {
            return snake.TopY == 0 || snake.LeftX == 0 ||
                snake.LeftX == this.LeftX - 1 || snake.TopY == this.TopY;
        }

        private void InitializeWallBorders()
        {
            SetHorizontalLine(0);
            SetHorizontalLine(this.TopY);

            SetVerticalLine(0);
            SetVerticalLine(this.LeftX - 1);
        }

        private void SetHorizontalLine(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }

        private void SetVerticalLine(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }
    }
}
