using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using Venge;
using Souls;

namespace Venge.Grid
{
	public class CellGrid
	{
		
		protected Cell[,] grid;
		
		
		public Cell[,] Grid {get {return grid;}}
		public Cell this[int x, int z]
		{
			get{return this.grid[x, z];}
			set{this.grid[x, z] = value;}
		}
		public int SizeX{get{return this.grid.GetLength(0);}}
		public int SizeZ{get{return this.grid.GetLength(1);}}
		
		public CellGrid(int x, int z)
		{
			this.grid = new Cell[x, z];
		}
		
	}
}

