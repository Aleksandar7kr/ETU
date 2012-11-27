#include "stdafx.h"
#include "frqvc.h"

void fileout(TCHAR* filename) {
	CFile out(filename, CFile::modeCreate|CFile::modeWrite);
	CArchive ar(&out, CArchive::store);
	int i;
	ar << nv << nr;
	for (i = 1; i <= nr; i++) {
		ar << in_r[i][0] << in_r[i][1] << z_r[i];
	}
}

void filein(TCHAR* filename) {
	CFile in;
	if (!in.Open(filename, CFile::modeRead)) {
		AfxMessageBox(_T("Ошибка в имени файла"));
		exit(1);
	}
	CArchive ar(&in, CArchive::load);
	int i;
	ar >> nv >> nr;
	for (i = 1; i <= nr; i++) {
		ar >> in_r[i][0] >> in_r[i][1] >> z_r[i];
	}
}