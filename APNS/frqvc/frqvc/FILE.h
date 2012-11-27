#pragma once


// диалоговое окно CFILE

class CFILE : public CDialogEx
{
	DECLARE_DYNAMIC(CFILE)

public:
	CFILE(CWnd* pParent = NULL);   // стандартный конструктор
	virtual ~CFILE();

// Данные диалогового окна
	enum { IDD = IDD_FILE };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	CString m_file;
	afx_msg void OnBnClickedFileokButton();
};
