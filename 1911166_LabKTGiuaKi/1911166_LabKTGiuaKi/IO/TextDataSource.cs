using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_LabKTGiuaKi.IO
{
	 public class TextDataSource : IODataSource
	 {
		  private const string _filePath = "Data\\data.txt";
		  public List<Students> getNews()
		  {
				List<Students> dsSV = new List<Students>();
				Students sv;
				string[] s;
				using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
				{
					 using (var reader = new StreamReader(stream))
					 {
						  while (!reader.EndOfStream)
						  {
								var line = reader.ReadLine();
								if (line == null)
								{
									 break;
								}
								else
								{
									 s = line.Split('\t');
									 sv = new Students();
									 sv.MSSV = s[0];
									 sv.HoTenLot = s[1];
									 sv.Ten = s[2];
									 sv.Lop = s[3];
									 sv.Khoa = s[4];
									 dsSV.Add(sv);
								}
						  }
					 }
				}
				return dsSV;
		  }

		  public void Save(List<Students> list)
		  {
				throw new NotImplementedException();
		  }
		  
	 }
}
