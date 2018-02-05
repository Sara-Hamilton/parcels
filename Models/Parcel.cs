using System;
using System.Collections.Generic;

class Parcel
{
  private int _height;
  private int _depth;
  private int _width;
  private int _weight;

  public void SetHeight(int newHeight)
  {
    _height = newHeight;
  }
  public int GetHeight()
  {
    return _height;
  }

  public void SetDepth(int newDepth)
  {
    _depth = newDepth;
  }
  public int GetDepth()
  {
    return _depth;
  }

  public void SetWidth(int newWidth)
  {
    _width = newWidth;
  }
  public int GetWidth()
  {
    return _width;
  }

  public void SetWeight(int newWeight)
  {
    _weight = newWeight;
  }
  public int GetWeight()
  {
    return _weight;
  }

  public Parcel(int parcelHeight, int parcelDepth, int parcelWidth, int parcelWeight)
  {
    SetHeight(parcelHeight);
    SetDepth(parcelDepth);
    SetWidth(parcelWidth);
    SetWeight(parcelWeight);
  }

  public int Volume(int inputHeight, int inputDepth, int inputWidth)
  {
    return (inputHeight * inputDepth * inputWidth);
  }

  public int CostToShip(int inputHeight, int inputDepth, int inputWidth, int inputWeight)
  {
    int volume = Volume(inputHeight, inputDepth, inputWidth);
    int totalCost = (volume * inputWeight) / 850;
    return totalCost;
  }
}

public class Program
{
  public static void Main()
  {
    Parcel newParcel = new Parcel(12,16,8,9);
    Console.WriteLine("Cost to ship: " + newParcel.CostToShip(newParcel.GetHeight(), newParcel.GetDepth(), newParcel.GetWidth(), newParcel.GetWeight()));

  }
}
