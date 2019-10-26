#pragma once
#include <Windows.h>
#include <time.h>
#include "VeKhung.h"
#include "ChucNang.h"
#include "CauHoi.h"
#include "ArrayCauHoi.h"
#include "DocGhiDuLieu.h"
#define MAUCHON 9
#define TIMEOUT 60
#define MAUNHAPNHAY 10
#define TIMEOUTNN 50
#define FILECAUHOI "cauhoi.txt"
class Choi
{
private:

	VeKhung cauHoi;
	VeKhung cauTraLoi1;
	VeKhung cauTraLoi2;
	VeKhung cauTraLoi3;
	VeKhung cauTraLoi4;
	VeKhung time;
	float times;
	ArrayCauHoi dsCauHoi;
	int cauHienTai;
	int soLuongCau;
public:
	Choi();
	void BatDauGame();
	void LoadCauHoiLen();
	void ChonMotCauNgauNhien();
	void InRaKetQua(bool kq);
	void InRaHetThoiGian();
	void InRaBanThang();
	void InHuongDan();
	void InRaDiem();
	void InRaDiemCuoiCung(bool kt);
	void NhapNhay(int dapAn);
	void MacDinh();
	void ChonDapAn1();
	void ChonDapAn2();
	void ChonDapAn3();
	void ChonDapAn4();
	void ShowTime();
};

