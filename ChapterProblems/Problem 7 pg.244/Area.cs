﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7_pg._244
{
    class Area
    {
        public static void Main()
        {
            int width = 7;
            int height = 2;
            ComputeArea(width, height);
            ComputeArea(Convert.ToDouble(width), Convert.ToDouble(height));
            ComputeArea(Convert.ToDouble(width), height);
        }
        public static void ComputeArea(int w, int h)
        {
            int area = w * h;
        }
        public static void ComputeArea(double w, double h)
        {
            double area = w * h;
        }
        public static void ComputeArea(double w, int h)
        {
            double area = w * h;
        }
    }
}
