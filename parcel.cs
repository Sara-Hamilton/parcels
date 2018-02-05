using System;
using System.Collections.Generic;

class Parcel
{
  private int _height;
  private int _depth;
  private int _width;
  private int _weight;

  public void SetHeight(string newHeight)
  {
    _height = newHeight;
  }
  public int GetHeight()
  {
    return _height;
  }

  public void SetDepth(string newDepth)
  {
    _depth = newDepth;
  }
  public int GetDepth()
  {
    return _depth;
  }

  public void SetWidth(string newWidth)
  {
    _width = newWidth;
  }
  public int GetWidth()
  {
    return _width;
  }

  public void SetWeight(string newWeight)
  {
    _weight = newWeight;
  }
  public int GetWeight()
  {
    return _weight;
  }
