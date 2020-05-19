using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public static int Length { get; set; }
    public static int Width { get; set; }
    public static int Height { get; set; }
    public static int Weight { get; set; }

    public void GetDimensions(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public int Volume()
    {
      int volume = Length * Width * Height;
      return volume;
    }

    public decimal Cost()
    {
      decimal cost = Math.Round(((Volume() * 1.5m) * (Weight * .6m)), 2);
      return cost;
    }

  }
}