#pragma once
#include "afxwin.h"


// ���������� ���� CRED

class CRED : public CDialogEx
{
	DECLARE_DYNAMIC(CRED)

public:
	CRED(CWnd* pParent = NULL);   // ����������� �����������
	virtual ~CRED();

// ������ ����������� ����
	enum { IDD = IDD_RED };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // ��������� DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnLbnDblclkRedList();
	CListBox m_redlst;
	virtual BOOL OnInitDialog();
	int m_np1;
	int m_nm1;
	int m_n;
	int m_np2;
	int m_nm2;
	float m_z1;
	float m_z2;
	float m_z3;
	float m_z4;
	float m_z5;
	float m_z6;
	afx_msg void OnBnClickedOutButton();
	afx_msg void OnBnClickedInButton();
};
