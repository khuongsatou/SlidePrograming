#include "stdafx.h"
#include "ArrayCauHoi.h"


void ArrayCauHoi::Add(CauHoi cauHoi)
{
	if (this->firt == NULL)
	{
		DuLieu *data = new DuLieu;
		data->data = cauHoi;
		data->link = NULL;

		this->firt = data;
		this->last = this->firt;
	}
	else
	{
		DuLieu *data = new DuLieu;
		data->data = cauHoi;
		data->link = NULL;

		this->last->link = data;
		this->last = data;
	}
}

CauHoi *ArrayCauHoi::Get(int i)
{
	DuLieu *conTro = this->firt;
	for (int j = 0; j < i; j++) conTro = conTro->link;
	return &(conTro->data);
}

void ArrayCauHoi::Set(int i, CauHoi data)
{
	DuLieu *conTro = this->firt;
	for (int j = 0; j < i; j++) conTro = conTro->link;
	conTro->data = data;
}

int ArrayCauHoi::Size()
{
	if (this->firt == NULL) return 0;
	int dem = 0;

	for (DuLieu *conTro = this->firt; conTro->link != NULL; conTro = conTro->link) dem++;

	return dem + 1;
}

void ArrayCauHoi::Clean()
{
	DuLieu *conTro = this->firt;
	while (conTro != NULL)
	{
		DuLieu *saoTro = conTro;
		conTro = conTro->link;
		delete saoTro;
	}
	this->firt = this->last = NULL;
}


ArrayCauHoi::ArrayCauHoi()
{
}


ArrayCauHoi::~ArrayCauHoi()
{
}
