#pragma once
// Ho ten: Nguyen Van Khuong
// MSSV: 0306171362
// Lop: CDTH17D

class KhoSach
{
public:
	KhoSach(){}
	~KhoSach(){}
	

};

class Sach
{
protected:
	int MaSach, NamXB;
	char* TenSach = new char[50];
public:
	Sach(){}
	~Sach(){}
	virtual void Nhap() = 0;
	virtual void Xuat() = 0;
	virtual float TinhTongTien() = 0;
};


class SachGiaoKhoa : public Sach
{
public:
	SachGiaoKhoa(){}
	~SachGiaoKhoa(){}

	virtual void Nhap(){
		cout << "Nhap Ma Sach:"; cin >> MaSach;
		fflush(stdin);
		cout << "Nhap Ten Sach:"; gets(TenSach);
	}
	virtual void Xuat() = 0;
	virtual float TinhTongTien() = 0;
};


class TruyenTranh : public Sach
{
public:
	TruyenTranh(){}
	~TruyenTranh(){}

	virtual void Nhap() = 0;
	virtual void Xuat() = 0;
	virtual float TinhTongTien() = 0;
};

class TieuThuyet : public Sach
{
public:
	TieuThuyet(){}
	~TieuThuyet(){}

	virtual void Nhap() = 0;
	virtual void Xuat() = 0;
	virtual float TinhTongTien() = 0;
};