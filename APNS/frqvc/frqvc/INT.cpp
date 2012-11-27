// INT.cpp: файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "INT.h"
#include "afxdialogex.h"


// диалоговое окно CINT

IMPLEMENT_DYNAMIC(CINT, CDialogEx)

CINT::CINT(CWnd* pParent /*=NULL*/)
	: CDialogEx(CINT::IDD, pParent)
	, m_address(_T(""))
{

}

CINT::~CINT()
{
}

void CINT::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EXPLORER1, m_browser);
	DDX_Control(pDX, IDC_COMBO, m_comb);
	DDX_CBString(pDX, IDC_COMBO, m_address);
	DDX_Control(pDX, IDC_BACK, m_back);
	DDX_Control(pDX, IDC_FORWARD, m_forward);
	DDX_Control(pDX, IDC_PROGRESS, m_progress);
}


BEGIN_MESSAGE_MAP(CINT, CDialogEx)
	ON_CBN_CLOSEUP(IDC_COMBO, &CINT::OnCbnCloseupCombo)
	ON_BN_CLICKED(IDC_INP, &CINT::OnBnClickedInp)
	ON_BN_CLICKED(IDC_BACK, &CINT::OnBnClickedBack)
	ON_BN_CLICKED(IDC_FORWARD, &CINT::OnBnClickedForward)
	ON_BN_CLICKED(IDC_STOP, &CINT::OnBnClickedStop)
	ON_BN_CLICKED(IDC_EXIT, &CINT::OnBnClickedExit)
END_MESSAGE_MAP()


// обработчики сообщений CINT


BOOL CINT::OnInitDialog()
{
	CDialogEx::OnInitDialog();
	m_browser.Navigate(_T("file:///C:/MF/beg.html"),0,0,0,0);
	m_comb.AddString(_T("file:///c:/mf/AppletParam.html"));
	m_comb.AddString(_T("file:///c:/mf/Int3d.htm"));
	m_comb.AddString(_T("http://google.com"));
	m_comb.AddString(_T("http://rambler.ru"));
	m_comb.AddString(_T("http://fedoraproject.org/"));
	m_comb.AddString(_T("http://play.google.com/store/apps/developer?id=JediSalat"));

	return TRUE;  // return TRUE unless you set the focus to a control
	// Исключение: страница свойств OCX должна возвращать значение FALSE
}


void CINT::OnCbnCloseupCombo()
{
	CString str;
	int ind = m_comb.GetCurSel();
	m_comb.GetLBText(ind, str);
	m_browser.Navigate((LPCTSTR)str, 0, 0, 0, 0);
	GetDlgItem(IDC_EXPLORER1)->SetFocus();
}


void CINT::OnBnClickedInp()
{
	UpdateData(TRUE);
	m_browser.Navigate((LPCTSTR)m_address, 0, 0, 0, 0);
}


void CINT::OnBnClickedBack()
{
	m_browser.GoBack();
}


void CINT::OnBnClickedForward()
{
	m_browser.GoForward();
}
BEGIN_EVENTSINK_MAP(CINT, CDialogEx)
	ON_EVENT(CINT, IDC_EXPLORER1, 105, CINT::CommandStateChangeExplorer1, VTS_I4 VTS_BOOL)
	ON_EVENT(CINT, IDC_EXPLORER1, 108, CINT::ProgressChangeExplorer1, VTS_I4 VTS_I4)
	ON_EVENT(CINT, IDC_EXPLORER1, 102, CINT::StatusTextChangeExplorer1, VTS_BSTR)
END_EVENTSINK_MAP()


void CINT::CommandStateChangeExplorer1(long Command, BOOL Enable)
{
	switch (Command) {
	case CSC_NAVIGATEFORWARD: 
		m_forward.EnableWindow(Enable);
		break;
	case CSC_NAVIGATEBACK:
		m_back.EnableWindow(Enable);
		break;
	}
}


void CINT::ProgressChangeExplorer1(long Progress, long ProgressMax)
{
	m_progress.SetRange(0, 100);
	m_progress.SetStep(0);
	m_progress.SetPos(0);
	if (Progress <= 0 | ProgressMax <= 0) {
		return;
	}
	m_progress.SetPos((int)Progress*100 / ProgressMax);
}


void CINT::StatusTextChangeExplorer1(LPCTSTR Text)
{
	SetDlgItemText(IDC_STATUS_TEXT, Text);
}


void CINT::OnBnClickedStop()
{
	m_browser.Stop();
}


void CINT::OnBnClickedExit()
{
	OnOK();
}
