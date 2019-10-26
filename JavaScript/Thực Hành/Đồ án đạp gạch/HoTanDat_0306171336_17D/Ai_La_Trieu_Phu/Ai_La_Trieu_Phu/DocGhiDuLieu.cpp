#include "stdafx.h"
#include "DocGhiDuLieu.h"


DocGhiDuLieu::DocGhiDuLieu(string a)
{
	file = a;
}

ArrayCauHoi DocGhiDuLieu::Doc()
{
	ArrayCauHoi list = ArrayCauHoi();
	f.open(this->file, ios::in);
	while (!f.eof())
	{
		string cauHoi = "";
		getline(f, cauHoi);

		string dapAn1 = "";
		getline(f, dapAn1);

		string dapAn2 = "";
		getline(f, dapAn2);

		string dapAn3 = "";
		getline(f, dapAn3);

		string dapAn4 = "";
		getline(f, dapAn4);

		string dapAn = "";
		getline(f, dapAn);

		CauHoi ch = CauHoi(cauHoi, dapAn1, dapAn2, dapAn3, dapAn4, stoi(dapAn));
		list.Add(ch);
	}
	f.close();
	return list;
}
