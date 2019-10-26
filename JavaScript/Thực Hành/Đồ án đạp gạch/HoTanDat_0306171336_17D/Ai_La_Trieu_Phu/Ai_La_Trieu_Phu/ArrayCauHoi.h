#pragma once
#include "CauHoi.h"
class ArrayCauHoi
{
private:
	struct DuLieu
	{
		CauHoi data;
		DuLieu *link;
	};
private:
	DuLieu *firt;
	DuLieu *last;
public:
	void Add(CauHoi data);
	CauHoi *Get(int i);
	void Set(int i, CauHoi data);
	int Size();
	void Clean();
public:
	ArrayCauHoi();
	~ArrayCauHoi();

};
