SET SQL DIALECT 3;

CREATE DATABASE 'C:\S2DEMO.FDB'
PAGE_SIZE 4096
user 'SYSDBA' password 'masterkey'
DEFAULT CHARACTER SET UNICODE_FSS;

/* Table: EMP2, Owner: SYSDBA */

CREATE TABLE "DEPT" 
(
	"DEPTNO" SMALLINT NOT NULL,
	"DNAME" VARCHAR(14) CHARACTER SET UNICODE_FSS,
	"LOC" VARCHAR(13) CHARACTER SET UNICODE_FSS,
	"VERSIONNO" INTEGER,
	"ACTIVE" SMALLINT,
	PRIMARY KEY ("DEPTNO")
);

CREATE TABLE "DEPT2" 
(
	"DEPTNO" SMALLINT NOT NULL,
	"DNAME" VARCHAR(14) CHARACTER SET UNICODE_FSS,
	"ACTIVE" SMALLINT,
	PRIMARY KEY ("DEPTNO")
);

CREATE TABLE "EMP" (
	"EMPNO" INTEGER NOT NULL,
	"ENAME" VARCHAR(10) CHARACTER SET UNICODE_FSS,
	"JOB" VARCHAR(9) CHARACTER SET UNICODE_FSS,
	"MGR" INTEGER,
	"HIREDATE" TIMESTAMP,
	"SAL" INTEGER,
	"COMM" DECIMAL(7, 2),
	"DEPTNO" SMALLINT,
	"TSTAMP" TIMESTAMP,
	PRIMARY KEY("EMPNO")
);

CREATE TABLE "EMP2" 
(
	"EMPNO" INTEGER NOT NULL,
	"ENAME" VARCHAR(10) CHARACTER SET UNICODE_FSS,
	"DEPTNUM" SMALLINT,
	PRIMARY KEY ("EMPNO")
);

CREATE TABLE "EMP_NULLABLE" (
	"EMPNO" INTEGER NOT NULL,
	"ENAME" VARCHAR(10),
	"JOB" VARCHAR(9),
	"MGR" INTEGER,
	"HIREDATE" TIMESTAMP,
	"SAL" INTEGER,
	"COMM" DECIMAL(7, 2),
	"DEPTNO" SMALLINT,
	"TSTAMP" TIMESTAMP,
	"NULLABLENEXTRESTDATE" TIMESTAMP,
	PRIMARY KEY("EMPNO")
);

CREATE TABLE "GENERIC_NULLABLE" (
	"ID" INTEGER NOT NULL,
	"DDATE" TIMESTAMP,
	"ENTITYNO" INTEGER,
	PRIMARY KEY("ID")
);
CREATE SEQUENCE "SEQ_GENERIC_NULLABLE";

CREATE TABLE "UNDER_SCORE" (
	"UNDER_SCORE_NO" DECIMAL(4, 0) NOT NULL,
	"TABLE_NAME" VARCHAR(50),
	"TABLE_NAME_" VARCHAR(50),
	"_TABLE_NAME" VARCHAR(50),
	"_TABLE_NAME_" VARCHAR(50),
	PRIMARY KEY("UNDER_SCORE_NO")
);

CREATE TABLE "IDTABLE" (
	"ID" INTEGER NOT NULL,
	"ID_NAME" VARCHAR(9),
	PRIMARY KEY("ID")
);
CREATE SEQUENCE "SEQ_IDTABLE";

CREATE TABLE "BASICTYPE" (
	"ID" DECIMAL(18, 0) NOT NULL,
	"BOOLTYPE" DECIMAL(1, 0),
	"BYTETYPE" DECIMAL(3, 0),
	"SBYTETYPE" DECIMAL(3, 0),
	"INT16TYPE" SMALLINT,
	"INT32TYPE" INTEGER,
	"INT64TYPE" BIGINT,
	"SINGLETYPE" FLOAT(8),
	"DOUBLETYPE" DOUBLE PRECISION,
	"DECIMALTYPE" DECIMAL(18, 0),
	"STRINGTYPE" VARCHAR(1024),
	"DATETIMETYPE" TIMESTAMP,
	PRIMARY KEY("ID")
);



/* Use GSEC (Create User)======================================== */
/* \FireBird_1_5\bin\gsec.exe -user sysdba -password masterkey    */
/* GSEC> add S2DEMO -pw s2demo                                    */
/* GSEC> quit                                                     */
/* End GSEC ===================================================== */


/* Grant permissions for this database */
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "DEPT" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "DEPT2" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "EMP" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "EMP2" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "EMP_NULLABLE" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "GENERIC_NULLABLE" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "UNDER_SCORE" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "IDTABLE" TO S2DEMO;
GRANT DELETE, INSERT, SELECT, UPDATE, REFERENCES ON "BASICTYPE" TO S2DEMO;

INSERT INTO "EMP" VALUES (7369, 'SMITH',  'CLERK',       7902, '1980-12-17 00:00:00',  800, NULL, 20, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7499, 'ALLEN',  'SALESMAN',    7698, '1981-02-20 00:00:00', 1600,  300, 30, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7521, 'WARD',   'SALESMAN',    7698, '1981-02-22 00:00:00', 1250,  500, 30, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7566, 'JONES',  'MANAGER',     7839, '1981-04-02 00:00:00', 2975, NULL, 20, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7654, 'MARTIN', 'SALESMAN',    7698, '1981-09-28 00:00:00', 1250, 1400, 30, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7698, 'BLAKE',  'MANAGER',     7839, '1981-05-01 00:00:00', 2850, NULL, 30, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7782, 'CLARK',  'MANAGER',     7839, '1981-06-09 00:00:00', 2450, NULL, 10, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7788, 'SCOTT',  'ANALYST',     7566, '1982-12-09 00:00:00', 3000, NULL, 20, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7839, 'KING',   'PRESIDENT',   NULL, '1981-11-17 00:00:00', 5000, NULL, 10, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7844, 'TURNER', 'SALESMAN',    7698, '1981-09-08 00:00:00', 1500,    0, 30, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7876, 'ADAMS',  'CLERK',       7788, '1983-01-12 00:00:00', 1100, NULL, 20, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7900, 'JAMES',  'CLERK',       7698, '1981-12-03 00:00:00',  950, NULL, 30, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7902, 'FORD',   'ANALYST',     7566, '1981-12-03 00:00:00', 3000, NULL, 20, '2000-01-01 00:00:00');
INSERT INTO "EMP" VALUES (7934, 'MILLER', 'CLERK',       7782, '1982-01-23 00:00:00', 1300, NULL, 10, '2000-01-01 00:00:00');
INSERT INTO "DEPT" VALUES (10, 'ACCOUNTING', 'NEW YORK', 0, 1);
INSERT INTO "DEPT" VALUES (20, 'RESEARCH',   'DALLAS',   0, 1);
INSERT INTO "DEPT" VALUES (30, 'SALES',      'CHICAGO',  0, 1);
INSERT INTO "DEPT" VALUES (40, 'OPERATIONS', 'BOSTON',   0, 1);
INSERT INTO "EMP2" VALUES (7369, 'SMITH', 20);
INSERT INTO "EMP2" VALUES (7499, 'ALLEN', 30);
INSERT INTO "EMP_NULLABLE" VALUES (1, 'ADAMS', 'CLERK', 7788, '1983-01-12 00:00:00', 1100, NULL, 20, '2000-01-01 00:00:00', '2006-11-07 00:00:00');
INSERT INTO "EMP_NULLABLE" VALUES (10, 'JAMES', 'CLERK', 7698, '1981-12-03 00:00:00', 950, NULL, 30, '2000-01-01 00:00:00', null);
INSERT INTO "EMP_NULLABLE" VALUES (100, 'FORD', 'ANALYST', 7566, '1981-12-03 00:00:00', 3000, NULL, 20, '2000-01-01 00:00:00', '2006-11-07 00:00:00');
INSERT INTO "GENERIC_NULLABLE" (ID, DDATE, ENTITYNO) VALUES (NEXT VALUE FOR "SEQ_GENERIC_NULLABLE", '2000-12-31 12:34:56', 100);
INSERT INTO "GENERIC_NULLABLE" (ID, DDATE, ENTITYNO) VALUES (NEXT VALUE FOR "SEQ_GENERIC_NULLABLE", NULL, 101);
INSERT INTO "UNDER_SCORE" VALUES (1,'table_name','table_name_','_table_name','_table_name_');
INSERT INTO "DEPT2" VALUES (20, 'RESEARCH', 1);
INSERT INTO "DEPT2" VALUES (30, 'SALES',    0);
INSERT INTO "BASICTYPE" VALUES (
    1,
    0,
    255,
    -128,
    32767,
    2147483647,
    9223372036854775807,
    9.876543,
    9.87654321098765,
    999999999999999999,
    '�|\\���`',
    '1980-12-17 12:34:56'
);
INSERT INTO "BASICTYPE" (
    id
) VALUES (
    2
);
INSERT INTO "BASICTYPE" VALUES (
    3,
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    '10',
    NULL
);

