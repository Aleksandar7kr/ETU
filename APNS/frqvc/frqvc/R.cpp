// R.cpp: файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "R.h"
#include "afxdialogex.h"


// диалоговое окно CR

IMPLEMENT_DYNAMIC(CR, CDialogEx)

CR::CR(CWnd* pParent /*=NULL*/)
	: CDialogEx(CR::IDD, pParent)
	, m_nextr(1)
	, m_npr(0)
	, m_nmr(0)
	, m_zr(0)
{

}

CR::~CR()
{
}

void CR::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_NEXTR, m_nextr);
	DDX_Text(pDX, IDC_NPR, m_npr);
	DDX_Text(pDX, IDC_NMR, m_nmr);
	DDX_Text(pDX, IDC_ZR, m_zr);
}


BEGIN_MESSAGE_MAP(CR, CDialogEx)
	ON_BN_CLICKED(IDC__NEXTR_BUTTON, &CR::OnBnClickedNextrButton)
END_MESSAGE_MAP()


// обработчики сообщений CR


void CR::OnBnClickedNextrButton()
{
	UpdateData(TRUE);
	in_r[m_nextr][0] = m_npr;
	in_r[m_nextr][1] = m_nmr;
	z_r[m_nextr] = m_zr;
	m_nextr++;
	if(m_nextr <= nr) {
		m_npr = 0;
		m_nmr = 0;
		m_zr = 0;
		GetDlgItem(IDC_NPR)->SetFocus();
		UpdateData(FALSE);
	}
	else OnOK();
}
