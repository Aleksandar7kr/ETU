#pragma once


// ���������� ���� CIO

class CIO : public CDialogEx
{
	DECLARE_DYNAMIC(CIO)

public:
	CIO(CWnd* pParent = NULL);   // ����������� �����������
	virtual ~CIO();

// ������ ����������� ����
	enum { IDD = IDD_IO };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // ��������� DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	int m_lp;
	int m_lm;
	int m_kp;
	int m_km;
	afx_msg void OnBnClickedIookButton();
};
