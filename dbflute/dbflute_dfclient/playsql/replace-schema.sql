
CREATE TABLE "dmyプロシージャ" (
  "dummy" CHAR(1)
);

-- 区分テーブル

CREATE TABLE "kbnメニュー区分" (
  "code" CHAR(3) NOT NULL PRIMARY KEY,
  "メニュー名" VARCHAR(20) NOT NULL,
  "優先順位" INT NOT NULL
);

CREATE TABLE "kbn職位区分" (
  "code" CHAR(3) NOT NULL PRIMARY KEY,
  "名称" VARCHAR(20) NOT NULL,
  "名称_英字" VARCHAR(20) NOT NULL
);

CREATE TABLE "kbn客室利用区分" (
  "code" CHAR(3) NOT NULL PRIMARY KEY,
  "名称" VARCHAR(20) NOT NULL
);

-- マスタテーブル

CREATE TABLE "mst制御画面マスタ" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "メニューcode" CHAR(3) NOT NULL,
  "画面名" VARCHAR(20) NOT NULL,
  "表示名" VARCHAR(20) NOT NULL,
  "優先順位" INT NOT NULL,
  FOREIGN KEY ("メニューcode") REFERENCES "kbnメニュー区分"("code")
);

CREATE TABLE "mst権限マスタ" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "職位code" CHAR(3) NOT NULL,
  "制御画面id" BIGINT NOT NULL,
  FOREIGN KEY ("職位code") REFERENCES "kbn職位区分"("code"),
  FOREIGN KEY ("制御画面id") REFERENCES "mst制御画面マスタ"("id")
);

CREATE TABLE "mst従業員マスタ" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "従業員番号" VARCHAR(20) UNIQUE NOT NULL,
  "氏名_姓" VARCHAR(20) NOT NULL,
  "氏名_名" VARCHAR(20) NOT NULL,
  "氏名_カナ" VARCHAR(50) NOT NULL,
  "メールアドレス" VARCHAR(255),
  "パスワード" VARCHAR(255) NOT NULL,
  "生年月日" TIMESTAMP(3) NOT NULL,
  "入社年月日" TIMESTAMP(3) NOT NULL,
  "退社年月日" TIMESTAMP(3),
  "職位code" CHAR(3) NOT NULL,
  "最終ログイン日時" TIMESTAMP(3),
  "備考" VARCHAR(255),
  FOREIGN KEY ("職位code") REFERENCES "kbn職位区分"("code")
);

CREATE TABLE "mst会員マスタ" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "会員番号" VARCHAR(9) UNIQUE NOT NULL,
  "氏名_姓" VARCHAR(20) NOT NULL,
  "氏名_名" VARCHAR(20) NOT NULL,
  "氏名_カナ" VARCHAR(50) NOT NULL,
  "会社名" VARCHAR(50),
  "会社名_カナ" VARCHAR(50),
  "電話番号" VARCHAR(20),
  "メールアドレス" VARCHAR(255),
  "入会年月日" TIMESTAMP(3) NOT NULL,
  "退会年月日" TIMESTAMP(3),
  "備考" VARCHAR(255)
);

CREATE TABLE "mst客室タイプマスタ" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "名称" VARCHAR(20) NOT NULL,
  "料金" INT NOT NULL,
  "宿泊人数" INT NOT NULL,
  "備考" VARCHAR(255)
);

CREATE TABLE "mst客室マスタ" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "客室番号" CHAR(3) UNIQUE NOT NULL,
  "客室タイプid" BIGINT NOT NULL,
  "喫煙" BOOLEAN NOT NULL,
  "備考" VARCHAR(255),
  FOREIGN KEY ("客室タイプid") REFERENCES "mst客室タイプマスタ"("id")
);

-- 台帳テーブル

CREATE TABLE "dch従業員職位履歴台帳" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "従業員id" BIGINT NOT NULL,
  "適用開始日" TIMESTAMP(3) NOT NULL,
  "適用終了日" TIMESTAMP(3) NOT NULL,
  "職位code" CHAR(3) NOT NULL,
  FOREIGN KEY ("従業員id") REFERENCES "mst従業員マスタ"("id"),
  FOREIGN KEY ("職位code") REFERENCES "kbn職位区分"("code")
);

CREATE TABLE "dch月締確定台帳" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "対象年月" TIMESTAMP(3) UNIQUE NOT NULL
);

CREATE TABLE "dch客室利用予定台帳" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "客室マスタid" BIGINT NOT NULL,
  "客室利用code" CHAR(3) NOT NULL,
  "利用開始日時" TIMESTAMP(3) NOT NULL,
  "利用終了日時" TIMESTAMP(3) NOT NULL,
  "備考" VARCHAR(255),
  FOREIGN KEY ("客室マスタid") REFERENCES "mst客室マスタ"("id"),
  FOREIGN KEY ("客室利用code") REFERENCES "kbn客室利用区分"("code")
);

CREATE TABLE "dch客室利用実績台帳" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "客室マスタid" BIGINT NOT NULL,
  "客室利用code" CHAR(3) NOT NULL,
  "利用開始日時" TIMESTAMP(3) NOT NULL,
  "利用終了日時" TIMESTAMP(3) NOT NULL,
  "備考" VARCHAR(255),
  FOREIGN KEY ("客室マスタid") REFERENCES "mst客室マスタ"("id"),
  FOREIGN KEY ("客室利用code") REFERENCES "kbn客室利用区分"("code")
);

CREATE TABLE "dch宿泊予定台帳" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "客室利用予定台帳id" BIGINT NOT NULL,
  FOREIGN KEY ("客室利用予定台帳id") REFERENCES "dch客室利用予定台帳"("id")
);

CREATE TABLE "dch宿泊実績台帳" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "客室利用実績台帳id" BIGINT NOT NULL,
  FOREIGN KEY ("客室利用実績台帳id") REFERENCES "dch客室利用実績台帳"("id")
);

-- シーケンス

CREATE SEQUENCE "mst001_id_seq";
CREATE SEQUENCE "mst002_id_seq";
CREATE SEQUENCE "mst003_id_seq";
CREATE SEQUENCE "mst004_id_seq";
CREATE SEQUENCE "mst005_id_seq";
CREATE SEQUENCE "mst006_id_seq";
ALTER TABLE "mst制御画面マスタ" ALTER COLUMN "id" SET DEFAULT nextval('mst001_id_seq');
ALTER TABLE "mst権限マスタ" ALTER COLUMN "id" SET DEFAULT nextval('mst002_id_seq');
ALTER TABLE "mst従業員マスタ" ALTER COLUMN "id" SET DEFAULT nextval('mst003_id_seq');
ALTER TABLE "mst会員マスタ" ALTER COLUMN "id" SET DEFAULT nextval('mst004_id_seq');
ALTER TABLE "mst客室タイプマスタ" ALTER COLUMN "id" SET DEFAULT nextval('mst005_id_seq');
ALTER TABLE "mst客室マスタ" ALTER COLUMN "id" SET DEFAULT nextval('mst006_id_seq');

CREATE SEQUENCE "dch001_id_seq";
CREATE SEQUENCE "dch002_id_seq";
CREATE SEQUENCE "dch003_id_seq";
CREATE SEQUENCE "dch004_id_seq";
CREATE SEQUENCE "dch005_id_seq";
CREATE SEQUENCE "dch006_id_seq";
ALTER TABLE "dch従業員職位履歴台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch001_id_seq');
ALTER TABLE "dch月締確定台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch002_id_seq');
ALTER TABLE "dch客室利用予定台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch003_id_seq');
ALTER TABLE "dch客室利用実績台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch004_id_seq');
ALTER TABLE "dch宿泊予定台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch005_id_seq');
ALTER TABLE "dch宿泊実績台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch006_id_seq');