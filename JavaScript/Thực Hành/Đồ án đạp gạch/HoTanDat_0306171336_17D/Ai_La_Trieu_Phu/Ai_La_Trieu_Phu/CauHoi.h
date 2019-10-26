#pragma once
#include <iostream>
using namespace std;
class CauHoi
{
private:
	string cauHoi;
	string dapAn1;
	string dapAn2;
	string dapAn3;
	string dapAn4;
	int ketQua;
	bool daTraLoi;
public:
	CauHoi();
	CauHoi(string cauhoi, string dapan1, string dapan2, string dapan3, string dapan4, int ketqua);
	~CauHoi();
public:
	bool KiemTraDapAn(int dapAn);
	string GetCauHoi();
	string GetDapAn1();
	string GetDapAn2();
	string GetDapAn3();
	string GetDapAn4();
	int GetDapAn();
	bool DaTraLoi();
};

