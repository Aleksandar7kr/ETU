#pragma once
#include "cwebbrowser2.h"
#include "afxwin.h"
#include "afxcmn.h"


// диалоговое окно CINT

class CINT : public CDialogEx
{
	DECLARE_DYNAMIC(CINT)

public:
	CINT(CWnd* pParent = NULL);   // стандартный конструктор
	virtual ~CINT();

// Данные диалогового окна
	enum { IDD = IDD_INT };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	CWebBrowser2 m_browser;
	virtual BOOL OnInitDialog();
	CComboBox m_comb;
	CString m_address;
	afx_msg void OnCbnCloseupCombo();
	afx_msg void OnBnClickedInp();
	CButton m_back;
	CButton m_forward;
	afx_msg void OnBnClickedBack();
	afx_msg void OnBnClickedForward();
	DECLARE_EVENTSINK_MAP()
	void CommandStateChangeExplorer1(long Command, BOOL Enable);
	CProgressCtrl m_progress;
	void ProgressChangeExplorer1(long Progress, long ProgressMax);
	void StatusTextChangeExplorer1(LPCTSTR Text);
	afx_msg void OnBnClickedStop();
	afx_msg void OnBnClickedExit();
};
