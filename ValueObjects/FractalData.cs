﻿using System.Collections.Generic;

namespace Fractal.NET.ValueObjects;

/// <summary>
/// TODO: дописать!
/// </summary>
public struct FractalData
{
    public int MaxIteration { get; set; }
    public List<List<int>> Counts { get; init; }
}