// F.cpp: файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "F.h"
#include "afxdialogex.h"


// диалоговое окно CF

IMPLEMENT_DYNAMIC(CF, CDialogEx)

CF::CF(CWnd* pParent /*=NULL*/)
	: CDialogEx(CF::IDD, pParent)
	, m_t1(_T("Значение частоты (КГц)"))
	, m_t2(_T(""))
	, m_t3(_T(""))
	, m_f1(_T(""))
	, m_f2(_T(""))
	, m_f3(_T(""))
	, m_f(0)
{

}

CF::~CF()
{
}

void CF::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_T1, m_t1);
	DDX_Text(pDX, IDC_T2, m_t2);
	DDX_Text(pDX, IDC_T3, m_t3);
	DDX_Text(pDX, IDC_F1, m_f1);
	DDX_Text(pDX, IDC_F2, m_f2);
	DDX_Text(pDX, IDC_F3, m_f3);
	DDX_Radio(pDX, IDC_F, m_f);
}


BEGIN_MESSAGE_MAP(CF, CDialogEx)
	ON_BN_CLICKED(IDC_F, &CF::OnBnClickedF)
	ON_BN_CLICKED(IDC_DF, &CF::OnBnClickedDf)
	ON_BN_CLICKED(IDC_Kf, &CF::OnBnClickedKf)
	ON_BN_CLICKED(IDC_FOK_BUTTON, &CF::OnBnClickedFokButton)
END_MESSAGE_MAP()


// обработчики сообщений CF


void CF::OnBnClickedF()
{
	GetDlgItem(IDC_F1)->SetFocus();
	m_f = 0;
	m_t1 = _T("Значение частоты (КГц)");
	m_t2 = m_t3 = "";
	UpdateData(FALSE);
}


void CF::OnBnClickedDf()
{
	GetDlgItem(IDC_F1)->SetFocus();
	m_f = 1;
	m_t1 = _T("Минимальная частота Fmin(КГц)");
	m_t2 = _T("Максимальная частота Fmax(КГц)");
	m_t3 = _T("Шаг изменения частоты dF(КГц)");
	UpdateData(FALSE);
}


void CF::OnBnClickedKf()
{
	GetDlgItem(IDC_F1)->SetFocus();
	m_f = 2;
	m_t1 = _T("Минимальная частота Fmin(КГц)");
	m_t2 = _T("Максимальная частота Fmax(КГц)");
	m_t3 = _T("Отношение соседних частот K");
	UpdateData(FALSE);
}


void CF::OnBnClickedFokButton()
{
	float fmax, df, kk;
	int kf;
	switch (m_f)
	{	case 0: UpdateData(TRUE);
				f[1] = atof(m_f1);
				nf = 1;
				break;

		case 1: UpdateData(TRUE);
				f[1] = atof(m_f1);
				fmax = atof(m_f2);
				df = atof(m_f3);
				kf = 1;
				while (f[kf] < fmax) {
					f[kf+1] = f[kf] + df;
					kf++;
				}
				nf = kf;
				break;

		case 2: UpdateData(TRUE);
				f[1] = atof(m_f1);
				fmax = atof(m_f2);
				kk = atof(m_f3);
				kf = 1;
				while (f[kf] < fmax) {
					f[kf+1] = kk*f[kf];
					kf++;
				}
				nf = kf;
				break;
	}
	OnOK();
}
