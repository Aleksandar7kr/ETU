
// frqvcDlg.h : ���� ���������
//

#pragma once


// ���������� ���� CfrqvcDlg
class CfrqvcDlg : public CDialogEx
{
// ��������
public:
	CfrqvcDlg(CWnd* pParent = NULL);	// ����������� �����������

// ������ ����������� ����
	enum { IDD = IDD_FRQVC_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// ��������� DDX/DDV


// ����������
protected:
	HICON m_hIcon;

	// ��������� ������� ����� ���������
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
