using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    private int _height;
    private int _depth;
    private int _width;
    private int _weight;
    private int _total;

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

    public void SetTotal(int newTotal)
    {
      _total = newTotal;
    }
    public int GetTotal()
    {
      return _total;
    }

    // public Parcel(int parcelHeight, int parcelDepth, int parcelWidth, int parcelWeight)
    // {
    //   SetHeight(parcelHeight);
    //   SetDepth(parcelDepth);
    //   SetWidth(parcelWidth);
    //   SetWeight(parcelWeight);
    // }

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
}
