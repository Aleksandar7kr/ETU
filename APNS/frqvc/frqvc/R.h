#pragma once


// диалоговое окно CR

class CR : public CDialogEx
{
	DECLARE_DYNAMIC(CR)

public:
	CR(CWnd* pParent = NULL);   // стандартный конструктор
	virtual ~CR();

// Данные диалогового окна
	enum { IDD = IDD_R };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedNextrButton();
	int m_nextr;
	int m_npr;
	int m_nmr;
	float m_zr;
};
