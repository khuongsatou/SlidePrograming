#include "stdafx.h"
#include "Choi.h"

Choi::Choi()
{
	this->cauHoi = VeKhung(20, 5, 80, 10, "");
	this->cauTraLoi1 = VeKhung(10, 17, 40, 5, "");
	this->cauTraLoi2 = VeKhung(70, 17, 40, 5, "");
	this->cauTraLoi3 = VeKhung(10, 25, 40, 5, "");
	this->cauTraLoi4 = VeKhung(70, 25, 40, 5, "");
	time = VeKhung(58, 22, 5, 3, "");
	times = TIMEOUT;

	DocGhiDuLieu doc = DocGhiDuLieu(FILECAUHOI);
	this->dsCauHoi = doc.Doc();
	this->ChonMotCauNgauNhien();
	this->soLuongCau = 1;
};
void Choi::BatDauGame()
{
	bool kt = true;
	char luaChon = 49;
	int dapAn = 1;
	this->LoadCauHoiLen();
	this->ChonDapAn1();
	this->InRaDiem();
	while (kt)
	{
		if (_kbhit())
		{
			char phim = _getch();
			switch (phim)
			{
			case 49:
				dapAn = 1;
				this->ChonDapAn1();
				luaChon = phim;
				break;
			case 50:
				dapAn = 2;
				this->ChonDapAn2();
				luaChon = phim;
				break;
			case 51:
				dapAn = 3;
				this->ChonDapAn3();
				luaChon = phim;
				break;
			case 52:
				dapAn = 4;
				this->ChonDapAn4();
				luaChon = phim;
				break;
			case 13:
				luaChon = phim;
				break;
			case 27:
				luaChon = phim;
				break;
			}
		}
		if (luaChon == 13)
		{
			NhapNhay((this->dsCauHoi.Get(cauHienTai))->GetDapAn());
			NhapNhay((this->dsCauHoi.Get(cauHienTai))->GetDapAn());
			if ((this->dsCauHoi.Get(cauHienTai))->KiemTraDapAn(dapAn))
			{
				if (this->soLuongCau == this->dsCauHoi.Size() || this->soLuongCau >= 15)
				{
					this->InRaBanThang();
					return;
				}
				this->times = TIMEOUT;
				this->InRaKetQua(true);
				this->ChonMotCauNgauNhien();
			}
			else
			{
				this->InRaKetQua(false);
				this->InRaDiemCuoiCung(true);
				return;
			}
			luaChon = 49;
			this->LoadCauHoiLen();
			this->InRaDiem();
			//this->Ve();
		}
		else if (luaChon == 27) kt = false;
		this->ShowTime();
		Sleep(100);
		if (this->times <= 0)
		{
			this->InRaHetThoiGian();
			return;
		}
	}
	this->InRaDiemCuoiCung(false);
}

void Choi::LoadCauHoiLen()
{
	ChucNang cn = ChucNang();
	system("cls");
	this->cauHoi.SetChuoi("Cau " + cn.ConvertInt(this->soLuongCau) + ": " + (this->dsCauHoi.Get(cauHienTai))->GetCauHoi());
	this->cauHoi.MauMacDinh();
	this->cauTraLoi1.SetChuoi("1:" + (this->dsCauHoi.Get(cauHienTai))->GetDapAn1());
	this->cauTraLoi2.SetChuoi("2:" + (this->dsCauHoi.Get(cauHienTai))->GetDapAn2());
	this->cauTraLoi3.SetChuoi("3:" + (this->dsCauHoi.Get(cauHienTai))->GetDapAn3());
	this->cauTraLoi4.SetChuoi("4:" + (this->dsCauHoi.Get(cauHienTai))->GetDapAn4());

	this->MacDinh();
	this->InHuongDan();
}

void Choi::ChonMotCauNgauNhien()
{
	int size = this->dsCauHoi.Size();
	bool Chon = true;
	while (Chon)
	{
		int index = rand() % size;
		CauHoi *ch = this->dsCauHoi.Get(index);
		if (!ch->DaTraLoi())
		{
			Chon = false;
			this->cauHienTai = index;
			this->soLuongCau++;
		}
	}
}

void Choi::InRaKetQua(bool kq)
{
	ChucNang cn;
	if (kq)
	{
		cn.TextColor(14);
		VeKhung vk = VeKhung(52, 20, 16, 5, "Ban da tra loi     dung");
		vk.Ve();
	}
	else
	{
		cn.TextColor(12);
		VeKhung vk = VeKhung(52, 20, 16, 5, "Ban da tra loi      sai");
		vk.Ve();
	}
	_getch();
}

void Choi::InRaHetThoiGian()
{
	VeKhung vk = VeKhung(52, 20, 16, 5, "Het Thoi Gian!");
	vk.Ve();
	_getch();
}

void Choi::InRaBanThang()
{
	VeKhung vk = VeKhung(52, 20, 16, 5, "Ban Da Thang");
	vk.Ve();
	_getch();
}

void Choi::InHuongDan()
{
	ChucNang cn = ChucNang();
	cn.GotoXY(1, 1);
	cn.TextColor(13);
	printf("           1:Chon Dap An 1, 2: Chon Dap An 2, 3: Chon Dap An 3, 4: CHon Dap An 4, Enter: Tra Loi, Esc: Dung Choi");
}

void Choi::InRaDiem()
{
	ChucNang cn;
	cn.GotoXY(57, 27);
	cn.TextColor(10);
	printf("Diem:%d", (this->soLuongCau - 1) * 10);
}

void Choi::InRaDiemCuoiCung(bool kt)
{
	if (kt)
	{
		if (this->soLuongCau < 5) this->soLuongCau = 1;
		else if (this->soLuongCau <= 5 && this->soLuongCau < 10) this->soLuongCau = 5;
		else if (this->soLuongCau != 15) this->soLuongCau = 10;
	}
	system("cls");
	VeKhung vk = VeKhung(35, 5, 50, 25, "");
	vk.Ve();
	ChucNang cn;
	cn.GotoXY(45, 13);
	printf("Diem Cuoi Cung Cua Ban La:%d", (this->soLuongCau - 1) * 10);
	_getch();
}

void Choi::NhapNhay(int dapAn)
{
	switch (dapAn)
	{
	case 1:
		this->cauTraLoi1.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi1.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi1.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi1.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi1.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		break;
	case 2:
		this->cauTraLoi2.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi2.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi2.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi2.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi2.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		break;
	case 3:
		this->cauTraLoi3.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi3.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi3.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi3.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi3.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		break;
	case 4:
		this->cauTraLoi4.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi4.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi4.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		this->cauTraLoi4.MauMacDinh();
		Sleep(TIMEOUTNN);
		this->cauTraLoi4.DoiMauKhung(MAUNHAPNHAY);
		Sleep(TIMEOUTNN);
		break;
	}
}

void Choi::MacDinh()
{
	//this->cauHoi.MauMacDinh();
	this->cauTraLoi1.MauMacDinh();
	this->cauTraLoi2.MauMacDinh();
	this->cauTraLoi3.MauMacDinh();
	this->cauTraLoi4.MauMacDinh();
	ChucNang cn = ChucNang();
	cn.GotoXY(1, 1);
}

void Choi::ChonDapAn1()
{
	this->MacDinh();
	this->cauTraLoi1.DoiMauKhung(MAUCHON);
}

void Choi::ChonDapAn2()
{
	this->MacDinh();
	this->cauTraLoi2.DoiMauKhung(MAUCHON);
}

void Choi::ChonDapAn3()
{
	this->MacDinh();
	this->cauTraLoi3.DoiMauKhung(MAUCHON);
}

void Choi::ChonDapAn4()
{
	this->MacDinh();
	this->cauTraLoi4.DoiMauKhung(MAUCHON);
}

void Choi::ShowTime()
{
	ChucNang cn;
	this->times -= (float)0.1;
	this->time.SetChuoi(cn.ConvertInt((int)this->times));
	this->time.DoiMauKhung(5);
}
