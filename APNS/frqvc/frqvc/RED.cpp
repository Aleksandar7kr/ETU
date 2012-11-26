// RED.cpp: файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "RED.h"
#include "afxdialogex.h"


// диалоговое окно CRED

IMPLEMENT_DYNAMIC(CRED, CDialogEx)

CRED::CRED(CWnd* pParent /*=NULL*/)
	: CDialogEx(CRED::IDD, pParent)
	, m_np1(0)
	, m_nm1(0)
	, m_n(1)
	, m_np2(0)
	, m_nm2(0)
	, m_z1(0)
	, m_z2(0)
	, m_z3(0)
	, m_z4(0)
	, m_z5(0)
	, m_z6(0)
{

}

CRED::~CRED()
{
}

void CRED::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_RED_LIST, m_redlst);
	DDX_Text(pDX, IDC_NP1, m_np1);
	DDX_Text(pDX, IDC_NM1, m_nm1);
	DDX_Text(pDX, IDC_N, m_n);
	DDX_Text(pDX, IDC_NP2, m_np2);
	DDX_Text(pDX, IDC_NM2, m_nm2);
	DDX_Text(pDX, IDC_Z1, m_z1);
	DDX_Text(pDX, IDC_Z2, m_z2);
	DDX_Text(pDX, IDC_Z3, m_z3);
	DDX_Text(pDX, IDC_Z4, m_z4);
	DDX_Text(pDX, IDC_Z5, m_z5);
	DDX_Text(pDX, IDC_Z6, m_z6);
}


BEGIN_MESSAGE_MAP(CRED, CDialogEx)
	ON_LBN_DBLCLK(IDC_RED_LIST, &CRED::OnLbnDblclkRedList)
	ON_BN_CLICKED(IDC_OUT_BUTTON, &CRED::OnBnClickedOutButton)
	ON_BN_CLICKED(IDC_IN_BUTTON, &CRED::OnBnClickedInButton)
END_MESSAGE_MAP()


// обработчики сообщений CRED


void CRED::OnLbnDblclkRedList()
{
	CString i1, i2, i3;
	int idx = m_redlst.GetCurSel();
	switch (idx) 
	{ case 0: i1 = "n+";
			  i2 = "n-";
			  i3 = "—опротивление (кќм)";
			  SetDlgItemText(IDC_NP2_STATIC, i1);
			  SetDlgItemText(IDC_NM2_STATIC, i2);
			  SetDlgItemText(IDC_Z1_STATIC, i3);

			  GetDlgItem(IDC_NP1)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_NM1)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z2)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z3)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z4)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z5)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z6)->ShowWindow(SW_HIDE);

			  GetDlgItem(IDC_NP1_STATIC)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_NM1_STATIC)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z2_STATIC)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z3_STATIC)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z4_STATIC)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z5_STATIC)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_Z6_STATIC)->ShowWindow(SW_HIDE);
			  GetDlgItem(IDC_N)->SetFocus();
			  break;
	}
}


BOOL CRED::OnInitDialog()
{
	CDialogEx::OnInitDialog();
	m_redlst.AddString(_T("–езисторы"));
	return TRUE;  // return TRUE unless you set the focus to a control
	// »сключение: страница свойств OCX должна возвращать значение FALSE
}


void CRED::OnBnClickedOutButton()
{
	int idx = m_redlst.GetCurSel();
	UpdateData(TRUE);
	k = m_n;
	switch (idx)
	{   case 0: m_np2 = in_r[k][0];
				m_nm2 = in_r[k][1];
				m_z1 = z_r[k];
				break;
	}
	UpdateData(FALSE);
	GetDlgItem(IDOK)->SetFocus();
}


void CRED::OnBnClickedInButton()
{
	int idx = m_redlst.GetCurSel();
	UpdateData(TRUE);
	k = m_n;
	switch (idx)
	{   case 0: in_r[k][0] = m_np2;
				in_r[k][1] = m_nm2;
				z_r[k] = m_z1;
				break;
	}
	UpdateData(FALSE);
	GetDlgItem(IDOK)->SetFocus();
}
