// FILE.cpp: файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "FILE.h"
#include "afxdialogex.h"


// диалоговое окно CFILE

IMPLEMENT_DYNAMIC(CFILE, CDialogEx)

CFILE::CFILE(CWnd* pParent /*=NULL*/)
	: CDialogEx(CFILE::IDD, pParent)
	, m_file(_T(""))
{

}

CFILE::~CFILE()
{
}

void CFILE::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_FILE, m_file);
}


BEGIN_MESSAGE_MAP(CFILE, CDialogEx)
	ON_BN_CLICKED(IDC_FILEOK_BUTTON, &CFILE::OnBnClickedFileokButton)
END_MESSAGE_MAP()


// обработчики сообщений CFILE


void CFILE::OnBnClickedFileokButton()
{
	switch (k) {
		case 0: UpdateData(TRUE);
				lstrcpy(filename, m_file);
				fileout(filename);
				break;
		case 1:	UpdateData(TRUE);
				lstrcpy(filename, m_file);
				filein(filename);
				break;
	}
	OnOK();
}
