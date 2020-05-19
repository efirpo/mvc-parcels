using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    public GetDimensions(string length, string width, string height, string weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public Volume()
    {
      int volume = Length * Width * Height;
      return volume;
    }

    public Cost()
    {
      decimal cost = (Volume() * 1.5) * (Weight * .6);
    }

  }
}