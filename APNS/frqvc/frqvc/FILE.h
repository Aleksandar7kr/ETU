#pragma once


// ���������� ���� CFILE

class CFILE : public CDialogEx
{
	DECLARE_DYNAMIC(CFILE)

public:
	CFILE(CWnd* pParent = NULL);   // ����������� �����������
	virtual ~CFILE();

// ������ ����������� ����
	enum { IDD = IDD_FILE };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // ��������� DDX/DDV

	DECLARE_MESSAGE_MAP()
public:
	CString m_file;
	afx_msg void OnBnClickedFileokButton();
};
