#pragma once


// ���������� ���� CSIZE

class CSIZE : public CDialogEx
{
	DECLARE_DYNAMIC(CSIZE)

public:
	CSIZE(CWnd* pParent = NULL);   // ����������� �����������
	virtual ~CSIZE();

// ������ ����������� ����
	enum { IDD = IDD_SIZE };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // ��������� DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnEnChangeEdit4();
	int m_nv;
	int m_nr;
	int m_nc;
	int m_nl;
	int m_ju;
	int m_eu;
	int m_ji;
	int m_ei;
	int m_ntb;
	int m_ntu;
	int m_nou;
	int m_ntr;
	int m_noui;
	int m_ntri;
};
