
// frqvc.h : главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить stdafx.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы
// Директивы препроцессора о включаемых в проект файлах
#include "COMPLEX.H"
#include "ZF_MW.H"
#include "SIZE.h"
#include "R.h"
#include "RED.h"
#include "FILE.h"
#include "F.h"
#include "IO.h"
#include "INT.h"



// CfrqvcApp:
// О реализации данного класса см. frqvc.cpp
//

class CfrqvcApp : public CWinApp
{
public:
	CfrqvcApp();

// Переопределение
public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern CfrqvcApp theApp;