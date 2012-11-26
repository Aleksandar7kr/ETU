#pragma once


// диалоговое окно CF

class CF : public CDialogEx
{
	DECLARE_DYNAMIC(CF)

public:
	CF(CWnd* pParent = NULL);   // стандартный конструктор
	virtual ~CF();

// Данные диалогового окна
	enum { IDD = IDD_F };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	CString m_t1;
	CString m_t2;
	CString m_t3;
	CString m_f1;
	CString m_f2;
	CString m_f3;
	afx_msg void OnBnClickedF();
	afx_msg void OnBnClickedDf();
	afx_msg void OnBnClickedKf();
	int m_f;
	afx_msg void OnBnClickedFokButton();
};
