#include "stdafx.h"
#include "CauHoi.h"


//CauHoi::CauHoi()
//{
//}

CauHoi::CauHoi(string cauhoi, string dapan1, string dapan2, string dapan3, string dapan4, int ketqua)
{
	this->cauHoi = cauhoi;
	this->dapAn1 = dapan1;
	this->dapAn2 = dapan2;
	this->dapAn3 = dapan3;
	this->dapAn4 = dapan4;
	this->ketQua = ketqua;
	this->daTraLoi = false;
}

//CauHoi::~CauHoi()
//{
//}


bool CauHoi::KiemTraDapAn(int dapAn)
{
	this->daTraLoi = true;
	if (dapAn == this->ketQua)
		return true;
	else return false;
}

string CauHoi::GetCauHoi()
{
	return this->cauHoi;
}

string CauHoi::GetDapAn1()
{
	return this->dapAn1;
}

string CauHoi::GetDapAn2()
{
	return this->dapAn2;
}

string CauHoi::GetDapAn3()
{
	return this->dapAn3;
}

string CauHoi::GetDapAn4()
{
	return this->dapAn4;
}

int CauHoi::GetDapAn()
{
	return this->ketQua;
}

bool CauHoi::DaTraLoi()
{
	return this->daTraLoi;
}
