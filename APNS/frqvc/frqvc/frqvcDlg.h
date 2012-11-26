
// frqvcDlg.h : файл заголовка
//

#pragma once


// диалоговое окно CfrqvcDlg
class CfrqvcDlg : public CDialogEx
{
// Создание
public:
	CfrqvcDlg(CWnd* pParent = NULL);	// стандартный конструктор

// Данные диалогового окна
	enum { IDD = IDD_FRQVC_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// поддержка DDX/DDV


// Реализация
protected:
	HICON m_hIcon;

	// Созданные функции схемы сообщений
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnExit();
	afx_msg void OnCons();
	afx_msg void OnRed();
	afx_msg void OnFile();
	afx_msg void OnF();
	afx_msg void OnIo();
	afx_msg void OnInternet();
	afx_msg void OnPriv();
	afx_msg void OnSys();
};
