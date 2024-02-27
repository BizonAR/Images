using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images
{
	internal class Images
	{
		static void Main(string[] args)
		{
			int numberPictures = 52;
			int picturesInRow = 3;
			int filledRows;
			int extraPictures;

			filledRows = numberPictures / picturesInRow;
			extraPictures = numberPictures % picturesInRow;

			Console.WriteLine($"Заполненных рядов: {filledRows}, картинок сверх меры: {extraPictures}");
		}
	}
}
