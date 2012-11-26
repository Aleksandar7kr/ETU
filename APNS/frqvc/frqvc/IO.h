#pragma once


// диалоговое окно CIO

class CIO : public CDialogEx
{
	DECLARE_DYNAMIC(CIO)

public:
	CIO(CWnd* pParent = NULL);   // стандартный конструктор
	virtual ~CIO();

// Данные диалогового окна
	enum { IDD = IDD_IO };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	int m_lp;
	int m_lm;
	int m_kp;
	int m_km;
	afx_msg void OnBnClickedIookButton();
};
