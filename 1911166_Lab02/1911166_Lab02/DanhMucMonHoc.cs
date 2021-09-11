﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1911166_Lab02
{
	 public class DanhMucMonHoc
	 {
		  public ArrayList ds;
		  public DanhMucMonHoc()
		  {
				ds = new ArrayList();
		  }
		  public MonHoc this[int index]
		  {
				get { return ds[index] as MonHoc; }
				set { ds[index] = value; }
		  }
		  public void Them(MonHoc mh)
		  {
				ds.Add(mh);
		  }
		  public override string ToString()
		  {
				string s = "Danh sach mon hoc: ";
				foreach(object mh in ds)
				{
					 s += mh as MonHoc + ";";
				}
				return s;
		  }
	 }
}
