using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911166_LabKTGiuaKi.IO
{
	 public interface IODataSource
	 {
		  List<Students> getNews();
		  void Save(List<Students> list);
	 }
}
