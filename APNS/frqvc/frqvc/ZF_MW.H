//ZF_MW.H
#if !defined(__ZF_MW_H)
#define __ZF_MW_H
#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include"complex.h"
const int M=100, MR=50, MC=50, ML=20, MEU=20, MF=20, MJU=20, MJI=20,
 MEI=20, MOUI=20, MTRI=20,MTR=20,MTB=20,MTU=20,MOU=20;
extern complex w[M+1][M+1],s;
extern TCHAR filename[20];
extern float om, a[M+1][M+1], b[M+1][M+1];
extern int nv, n, nr, nc, nl, nju,neu,nji,nei,noui,ntri,ntr,ntb,ntu,nou,nf,lp,lm,kp,km,k;
extern int in_r[MR+1][2], in_c[MC+1][2], in_l[ML+1][2], in_eu[MEU+1][4], in_ju[MJU+1][4], in_ji[MJI+1][4], in_ei[MEI+1][4], in_oui[MOUI+1][4], in_tri[MTRI+1][4], in_tb[MTB+1][4],in_tu[MTU+1][4],  in_ou[MOU+1][5], in_tr[MTR+1][4];
extern float z_r[MR+1], z_c[MC+1], z_l[ML+1], z_eu[MEU+1][3], z_ju[MJU+1][3], z_ji[MJI+1], z_ei[MEI+1], z_tri[MTRI+1], z_tb[MTB+1][6], z_tu[MTU+1][5], z_ou[MOU+1][4], z_tr[MTR+1][5],  f[MF+1];
extern float kum[MF+1],kua[MF+1],rim[MF+1],ria[MF+1],rom[MF+1], roa[MF+1];
void filein(TCHAR* filename);
void fileout(TCHAR* filename);
void form_d(int in_d[][2],float z_d[],int nd,char td);
void form1_d(int in_d[][2],float z_d[],int nd,char td);
void form1_eu();
void form_eu();
void form1_ju();
void form_ju();
void form_ji();
void form1_ji();
void form1_ei();
void form_ei();
void form_oui();
void form_tri();
void form_tr();
void form1_oui();
void form1_tri();
void form_tb();
void form_tu();
void form1_tb();
void form1_tu();
void form_ou();
void form1_ou();
void form_w();
void form_s();
void st();
void sf1(int kf);
void gauss_c();
void sf2(int kf);
void write_out();
#endif

