using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
namespace CoffeeManagement.Utilities
{
	public static class ExcelHelper
	{
		//rule of thumb for releasing com objects:
		//  never use two dots, all COM objects must be referenced and released individually
		//  ex: [somthing].[something].[something] is bad

		private static Excel.Application _xlApp;
		private static Excel.Workbook _xlWorkbook;
		private static Excel._Worksheet _xlWorksheet;
		private static Excel.Range _xlRange;

		private static List<object> _lineData = new List<object>();
		static ExcelHelper()
		{
			//Create COM Objects. Create a COM object for everything that is referenced
			_xlApp = new Excel.Application();
		}

		/// <summary>
		/// Open file excel with file full path, sheet index starts at 1.
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="sheetIndex"></param>
		public static void LoadFile(string filePath, int sheetIndex = 1)
		{
			try
			{
				_xlWorkbook = _xlApp.Workbooks.Open(filePath);
				_xlWorksheet = _xlWorkbook.Sheets[sheetIndex];
				_xlRange = _xlWorksheet.UsedRange;
			}
			catch (Exception ex)
			{
				MessageHelper.CreateErrorMessage(ex.Message);
			}
		}

		/// <summary>
		/// Read excel from line to line.
		/// endLineIndex = 0 means read whole file.
		/// startLineIndex starts from 1.
		/// Lines at startLineIndex and endLineIndex are included.
		/// </summary>
		/// <param name="startLineIndex"></param>
		/// <param name="endLineIndex"></param>
		/// <returns></returns>
		public static IEnumerable<List<object>> ReadLine(int startLineIndex = 1, int endLineIndex = 0)
		{
			if (_xlWorkbook == null)
			{
				throw new Exception("Load file first");
			}
			
			if (_xlWorksheet == null)
			{
				throw new Exception("Sheet is null");
			}

			int rowCount = _xlRange.Rows.Count;
			int colCount = _xlRange.Columns.Count;

			//excel is not zero based!!
			for (int r = startLineIndex; r <= rowCount; r++)
			{
				if (endLineIndex > 0)
				{
					if (r > endLineIndex)
					{
						break;
					}
				}

				_lineData = new List<object>();
				for (int c = 1; c <= colCount; c++)
				{
					if (_xlRange.Cells[r, c] != null)
					{
						_lineData.Add(_xlRange.Cells[r, c].Value2);	
					}
				}

				yield return _lineData;
			}

			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		public static void CleanAndClose()
		{
			try
			{
				
				//release com objects to fully kill excel process from running in the background
				Marshal.ReleaseComObject(_xlRange);
				Marshal.ReleaseComObject(_xlWorksheet);

				//close and release
				_xlWorkbook.Close();
				Marshal.ReleaseComObject(_xlWorkbook);

				//quit and release
				_xlApp.Quit();
				Marshal.ReleaseComObject(_xlApp);
			}
			catch
			{
			}
		}
	}
}
