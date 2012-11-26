// IO.cpp: файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "IO.h"
#include "afxdialogex.h"


// диалоговое окно CIO

IMPLEMENT_DYNAMIC(CIO, CDialogEx)

CIO::CIO(CWnd* pParent /*=NULL*/)
	: CDialogEx(CIO::IDD, pParent)
	, m_lp(0)
	, m_lm(0)
	, m_kp(0)
	, m_km(0)
{

}

CIO::~CIO()
{
}

void CIO::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_LP, m_lp);
	DDX_Text(pDX, IDC_LM, m_lm);
	DDX_Text(pDX, IDC_KP, m_kp);
	DDX_Text(pDX, IDC_KM, m_km);
}


BEGIN_MESSAGE_MAP(CIO, CDialogEx)
	ON_BN_CLICKED(IDC_IOOK_BUTTON, &CIO::OnBnClickedIookButton)
END_MESSAGE_MAP()


// обработчики сообщений CIO


void CIO::OnBnClickedIookButton()
{
	UpdateData(TRUE);
	lp = m_lp;
	lm = m_lm;
	kp = m_kp;
	km = m_km;
	OnOK();
}
