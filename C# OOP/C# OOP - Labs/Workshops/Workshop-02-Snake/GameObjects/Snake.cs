using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeWorkshop.GameObjects
{
    public class Snake
    {
        private const char snakeSymbol = '\u25CF';

        private readonly Queue<Point> snakeElements;
        private readonly Food[] foods;
        private readonly Wall wall;

        private int nextLeftX;
        private int nextTopY;
        private int foodIndex;


        public Snake(Wall wall)
        {
            this.wall = wall;
            this.foods = new Food[3];

            this.foodIndex = this.RandomFoodNumber;
            this.snakeElements = new Queue<Point>();

            this.GetFoods();
            this.CreateSnake();
        }

        public int RandomFoodNumber
            => new Random().Next(0, this.foods.Length);

        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = snakeElements.Last();

            GetNextPoint(direction, currentSnakeHead);

            bool isPointOfSnake = snakeElements
                .Any(x=>x.LeftX == nextLeftX && x.TopY == nextTopY);

            if (isPointOfSnake)
            {
                return false;
            }

            Point snakeNewHead = new Point(nextLeftX, nextTopY);

            if (wall.IsPointOfWall(snakeNewHead))
            {
                return false;
            }

            this.snakeElements.Enqueue(snakeNewHead);
            snakeNewHead.Draw(snakeSymbol);

            if (this.foods[this.foodIndex].IsFoodPoint(snakeNewHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();

            snakeTail.Draw(' ');

            return true;
        }

        private void CreateSnake()
        {
            for (int topY = 1; topY <= 6; topY++)
            {
                snakeElements.Enqueue(new Point(2, topY));
            }

            this.foods[this.foodIndex].SetRandomPosition(snakeElements);
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = this.foods[this.foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                this.GetNextPoint(direction, currentSnakeHead);
            }

            this.wall.AddPoints(this.snakeElements);
            this.wall.PlayerInfo();

            this.foodIndex = this.RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(snakeElements);
        }

        private void GetFoods()
        {
            foods[0] = new FoodHash(wall);
            foods[1] = new FoodDollar(wall);
            foods[2] = new FoodAsterisk(wall);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }



    }
}
