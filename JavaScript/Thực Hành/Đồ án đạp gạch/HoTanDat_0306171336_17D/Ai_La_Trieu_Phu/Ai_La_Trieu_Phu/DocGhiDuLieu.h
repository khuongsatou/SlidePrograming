#pragma once
#include <iostream>
#include "CauHoi.h"
#include "ArrayCauHoi.h"
#include <fstream>
#include "ChucNang.h"
#include <string>
#include <stdlib.h>

using namespace std;
class DocGhiDuLieu
{
private:
	string file;
	/*char *file=new char[30];*/
	fstream f;
public:
	DocGhiDuLieu(string file);
	ArrayCauHoi Doc();
};

