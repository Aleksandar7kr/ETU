
// frqvcDlg.cpp : файл реализации
//

#include "stdafx.h"
#include "frqvc.h"
#include "frqvcDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

int nv, nr, nc, nl, nf, ju, eu, ji, ei,
	ntb, ntu, nou, ntr, noui, ntri,
	lp, lm, kp, km, flag,
	k; // CRED value of the element m_n
int in_r[MR+1][2];
float z_r[MR+1], f[MF+1];

// Диалоговое окно CAboutDlg используется для описания сведений о приложении

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Данные диалогового окна
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

// Реализация
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// диалоговое окно CfrqvcDlg




CfrqvcDlg::CfrqvcDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CfrqvcDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CfrqvcDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CfrqvcDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_COMMAND(ID_EXIT, &CfrqvcDlg::OnExit)
	ON_COMMAND(ID_CONS, &CfrqvcDlg::OnCons)
	ON_COMMAND(ID_RED, &CfrqvcDlg::OnRed)
	ON_COMMAND(ID_FILE, &CfrqvcDlg::OnFile)
	ON_COMMAND(ID_F, &CfrqvcDlg::OnF)
	ON_COMMAND(ID_IO, &CfrqvcDlg::OnIo)
	ON_COMMAND(ID_INTERNET, &CfrqvcDlg::OnInternet)
	ON_COMMAND(ID_PRIV, &CfrqvcDlg::OnPriv)
	ON_COMMAND(ID_SYS, &CfrqvcDlg::OnSys)
END_MESSAGE_MAP()


// обработчики сообщений CfrqvcDlg

BOOL CfrqvcDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Добавление пункта "О программе..." в системное меню.

	// IDM_ABOUTBOX должен быть в пределах системной команды.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Задает значок для этого диалогового окна. Среда делает это автоматически,
	//  если главное окно приложения не является диалоговым
	SetIcon(m_hIcon, TRUE);			// Крупный значок
	SetIcon(m_hIcon, FALSE);		// Мелкий значок

	// TODO: добавьте дополнительную инициализацию

	return TRUE;  // возврат значения TRUE, если фокус не передан элементу управления
}

void CfrqvcDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// При добавлении кнопки свертывания в диалоговое окно нужно воспользоваться приведенным ниже кодом,
//  чтобы нарисовать значок. Для приложений MFC, использующих модель документов или представлений,
//  это автоматически выполняется рабочей областью.

void CfrqvcDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // контекст устройства для рисования

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Выравнивание значка по центру клиентского прямоугольника
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Нарисуйте значок
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// Система вызывает эту функцию для получения отображения курсора при перемещении
//  свернутого окна.
HCURSOR CfrqvcDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CfrqvcDlg::OnExit()
{
	OnOK();
}

void CfrqvcDlg::OnCons()
{ 
	int result;
	CSIZE size;
	result = size.DoModal();
	if(result == IDOK)
	{
		nv = size.m_nv;
		nr = size.m_nr;
		nc = size.m_nc;
		nl = size.m_nl;
		ju = size.m_ju;
		eu = size.m_eu;
		ji = size.m_ji;
		ei = size.m_ei;
		ntb = size.m_ntb;
		ntu = size.m_ntu;
		nou = size.m_nou;
		ntr = size.m_ntr;
		noui = size.m_noui;
		ntri = size.m_ntri;
	}
	if(nr)
	{
		
		CR r;
		r.DoModal();
		
	}
	int res = MessageBox(_T("Выводить описание схемы в файл"),
		_T("Вывод в файл"), MB_YESNO);
	if (res == IDYES) {
		k = 0;
		CFILE file;
		file.DoModal();
	}
	CF fi;
	fi.DoModal();
	CIO io;
	io.DoModal();
}

void CfrqvcDlg::OnRed()
{
	CRED red;
	red.DoModal();
	MessageBox(_T("Выберите в меню дальнейший режим работы"),_T("Режим работы"),MB_OK);
}


void CfrqvcDlg::OnFile()
{
	k = 1;
	CFILE file;
	file.DoModal();
}


void CfrqvcDlg::OnF()
{
	CF fi;
	fi.DoModal();
	MessageBox(_T("Выберите в меню дальнейший режим работы"),
		_T("Режим работы"), MB_OK);
}


void CfrqvcDlg::OnIo()
{
	CIO io;
	io.DoModal();
	MessageBox(_T("Выберите в меню дальнейший режим работы"),
		_T("Режим работы"), MB_OK);
}


void CfrqvcDlg::OnInternet()
{
	if (flag == 0) {
		CINT in;
		in.DoModal();
	}
	else {
		ShellExecute(NULL, _T("open"), 
			_T("file:///C:/MF/beg.html"),
			NULL, NULL, SW_SHOWNORMAL);
	}
}


void CfrqvcDlg::OnPriv()
{
	flag = 0;
}


void CfrqvcDlg::OnSys()
{
	flag = 1;
}
