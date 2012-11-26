// SIZE.cpp: файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "SIZE.h"
#include "afxdialogex.h"


// диалоговое окно CSIZE

IMPLEMENT_DYNAMIC(CSIZE, CDialogEx)

CSIZE::CSIZE(CWnd* pParent /*=NULL*/)
	: CDialogEx(CSIZE::IDD, pParent)
	, m_nv(0)
	, m_nr(0)
	, m_nc(0)
	, m_nl(0)
	, m_ju(0)
	, m_eu(0)
	, m_ji(0)
	, m_ei(0)
	, m_ntb(0)
	, m_ntu(0)
	, m_nou(0)
	, m_ntr(0)
	, m_noui(0)
	, m_ntri(0)
{

}

CSIZE::~CSIZE()
{
}

void CSIZE::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_NV, m_nv);
	DDX_Text(pDX, IDC_NR, m_nr);
	DDX_Text(pDX, IDC_NC, m_nc);
	DDX_Text(pDX, IDC_NL, m_nl);
	DDX_Text(pDX, IDC_NJU, m_ju);
	DDX_Text(pDX, IDC_NEU, m_eu);
	DDX_Text(pDX, IDC_NJI, m_ji);
	DDX_Text(pDX, IDC_NEI, m_ei);
	DDX_Text(pDX, IDC_NTB, m_ntb);
	DDX_Text(pDX, IDC_NTU, m_ntu);
	DDX_Text(pDX, IDC_NOU, m_nou);
	DDX_Text(pDX, IDC_NTR, m_ntr);
	DDX_Text(pDX, IDC_NOUI, m_noui);
	DDX_Text(pDX, IDC_NTRI, m_ntri);
}


BEGIN_MESSAGE_MAP(CSIZE, CDialogEx)
	ON_EN_CHANGE(IDC_NV, &CSIZE::OnEnChangeEdit4)
END_MESSAGE_MAP()


// обработчики сообщений CSIZE


void CSIZE::OnEnChangeEdit4()
{
	// TODO:  Если это элемент управления RICHEDIT, то элемент управления не будет
	// send this notification unless you override the CDialogEx::OnInitDialog()
	// function and call CRichEditCtrl().SetEventMask()
	// with the ENM_CHANGE flag ORed into the mask.

	// TODO:  Добавьте код элемента управления
}
