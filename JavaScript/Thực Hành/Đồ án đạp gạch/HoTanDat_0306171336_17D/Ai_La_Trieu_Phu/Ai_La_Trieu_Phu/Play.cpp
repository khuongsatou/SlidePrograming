// AiLaTrieuPhu.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
//#include "VeKhung.h"
#include <conio.h>
#include <Windows.h>
#include "Menu.h"
#include "Choi.h"
#include "DocGhiDuLieu.h"
#include"ArrayCauHoi.h"
#include"CauHoi.h"
using namespace std;

int main()
{
	ChucNang cn = ChucNang();
	cn.Deletec();
	Menu menu = Menu();
	menu.ShowMenu();
	menu.ChonBatDau();

	int luaChon = 1;
	bool thoat = true;

	while (thoat)
	{
		char chon = _getch();
		switch (chon)
		{
		case 49:
		{
				   menu.ChonBatDau();
				   luaChon = 1;
				   break;
		}
		case 50:
			menu.ChonThongTin();
			luaChon = 2;
			break;
		case 51:
			menu.ChonThoat();
			luaChon = 3;
			break;
		default:
			break;
		}

		if (chon == 13)
		{
			switch (luaChon)
			{
			case 1:
			{
					  Choi choi = Choi();
					  choi.BatDauGame();
					  menu.ShowMenu();
					  break;
			}
			case 2:
				menu.InThongTin();
				menu.ShowMenu();
				luaChon = 1;
				break;
			case 3:
				thoat = false;
			}
		}
	}


	return 0;
}

