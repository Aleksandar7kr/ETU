
// frqvc.h : ������� ���� ��������� ��� ���������� PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "�������� stdafx.h �� ��������� ����� ����� � PCH"
#endif

#include "resource.h"		// �������� �������
// ��������� ������������� � ���������� � ������ ������
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
// � ���������� ������� ������ ��. frqvc.cpp
//

class CfrqvcApp : public CWinApp
{
public:
	CfrqvcApp();

// ���������������
public:
	virtual BOOL InitInstance();

// ����������

	DECLARE_MESSAGE_MAP()
};

extern CfrqvcApp theApp;