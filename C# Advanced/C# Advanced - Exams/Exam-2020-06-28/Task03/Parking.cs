using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.Exists(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                data.Remove(data.Find(x => x.Manufacturer == manufacturer && x.Model == model));
                return true;
            }
            return false;
        }

        public Car GetLatestCar()
        {
            if (data.Count == 0)
            {
                return null;
            }

            return data.OrderByDescending(x => x.Year).First();
        }

        public Car GetCar(string manufacturer, string model)
        {
            if (data.Exists(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                return data.Find(x => x.Manufacturer == manufacturer && x.Model == model);
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"The cars are parked in {Type}:{Environment.NewLine}");

            for (int i = 0; i < data.Count; i++)
            {
                sb.Append(data[i].ToString());

                if (i != data.Count - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }
    }
}
