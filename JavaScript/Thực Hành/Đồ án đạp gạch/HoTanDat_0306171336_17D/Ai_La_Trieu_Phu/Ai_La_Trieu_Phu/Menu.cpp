#include "stdafx.h"
#include "Menu.h"
#include "VeKhung.h"


Menu::Menu()
{
	this->baoNgoai = VeKhung(35, 5, 50, 25, "");
	this->batDau = VeKhung(46, 8, 27, 5, "         Bat Dau");
	this->troGiup = VeKhung(46, 15, 27, 5, "        Thong Tin");
	this->thoat = VeKhung(46, 22, 27, 5, "          Thoat");
}


Menu::~Menu()
{
}

void Menu::ShowMenu()
{
	system("cls");
	this->baoNgoai.Ve();
	this->baoNgoai.MauMacDinh();
	this->batDau.Ve();
	this->troGiup.Ve();
	this->thoat.Ve();
	this->ChonBatDau();
	this->InHuongDan();
}

void Menu::ChonBatDau()
{
	this->batDau.DoiMauKhung(3);
	this->troGiup.MauMacDinh();
	this->thoat.MauMacDinh();
}

void Menu::ChonThongTin()
{
	this->batDau.MauMacDinh();
	this->troGiup.DoiMauKhung(3);
	this->thoat.MauMacDinh();
}

void Menu::ChonThoat()
{
	this->batDau.MauMacDinh();
	this->troGiup.MauMacDinh();
	this->thoat.DoiMauKhung(3);
}

void Menu::InHuongDan()
{
	ChucNang cn = ChucNang();
	cn.GotoXY(1, 1);
	cn.TextColor(13);
	printf("                     1:Chon Bat Dau, 2: Chon Tro Giup, 3: Chon Thoat, Enter: Chon, Esc: Thoat");
}

void Menu::InThongTin()
{
	system("cls");
	VeKhung bao = VeKhung(35, 5, 50, 25, "");
	bao.SetChuoi("\t\t\tTAC GIA");
	bao.Ve();
	_getch();
}
