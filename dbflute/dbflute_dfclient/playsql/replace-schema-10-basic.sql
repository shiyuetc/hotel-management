CREATE TABLE "dmyプロシージャ" (
  "dummy" CHAR(1)
);
COMMENT ON TABLE dmyプロシージャ IS 'プロシージャ';
COMMENT ON COLUMN dmyプロシージャ.dummy IS 'ダミー';

-- 区分テーブル

CREATE TABLE "kbnメニュー区分" (
  "メニューコード" CHAR(2) NOT NULL PRIMARY KEY,
  "メニュー名称" VARCHAR(20) NOT NULL,
  "優先順位" INT NOT NULL
);
COMMENT ON TABLE kbnメニュー区分 IS 'メニュー区分';
COMMENT ON COLUMN kbnメニュー区分.メニューコード IS 'メニューコード';
COMMENT ON COLUMN kbnメニュー区分.メニュー名称 IS 'メニュー名称';
COMMENT ON COLUMN kbnメニュー区分.優先順位 IS '優先順位';

CREATE TABLE "kbn職位区分" (
  "職位コード" CHAR(3) NOT NULL PRIMARY KEY,
  "職位名称" VARCHAR(20) NOT NULL,
  "職位英字名称" VARCHAR(20) NOT NULL
);
COMMENT ON TABLE kbn職位区分 IS '職位区分';
COMMENT ON COLUMN kbn職位区分.職位コード IS '職位コード';
COMMENT ON COLUMN kbn職位区分.職位名称 IS '職位名称';
COMMENT ON COLUMN kbn職位区分.職位英字名称 IS '職位英字名称';

CREATE TABLE "kbn客室利用区分" (
  "客室利用コード" CHAR(2) NOT NULL PRIMARY KEY,
  "客室利用名称" VARCHAR(20) NOT NULL
);
COMMENT ON TABLE kbn客室利用区分 IS '客室利用区分';
COMMENT ON COLUMN kbn客室利用区分.客室利用コード IS '客室利用コード';
COMMENT ON COLUMN kbn客室利用区分.客室利用名称 IS '客室利用名称';

-- マスタテーブル

CREATE TABLE "mst画面マスタ" (
  "画面コード" CHAR(3) NOT NULL PRIMARY KEY,
  "メニューコード" CHAR(3) NOT NULL,
  "画面名称" VARCHAR(20) NOT NULL,
  "優先順位" INT NOT NULL,
  FOREIGN KEY ("メニューコード") REFERENCES "kbnメニュー区分"("メニューコード")
);
COMMENT ON TABLE mst画面マスタ IS '画面マスタ';
COMMENT ON COLUMN mst画面マスタ.画面コード IS '画面コード';
COMMENT ON COLUMN mst画面マスタ.メニューコード IS 'メニューコード';
COMMENT ON COLUMN mst画面マスタ.画面名称 IS '画面名称';
COMMENT ON COLUMN mst画面マスタ.優先順位 IS '優先順位';

CREATE TABLE "mst権限マスタ" (
  "職位コード" CHAR(3) NOT NULL,
  "画面コード" CHAR(3) NOT NULL,
  FOREIGN KEY ("職位コード") REFERENCES "kbn職位区分"("職位コード"),
  FOREIGN KEY ("画面コード") REFERENCES "mst画面マスタ"("画面コード"),
  PRIMARY KEY ("職位コード", "画面コード")
);
COMMENT ON TABLE mst権限マスタ IS '権限マスタ';
COMMENT ON COLUMN mst権限マスタ.職位コード IS '職位コード';
COMMENT ON COLUMN mst権限マスタ.画面コード IS '画面コード';

CREATE TABLE "mst従業員マスタ" (
  "従業員コード" CHAR(10) PRIMARY KEY,
  "従業員番号" VARCHAR(20) UNIQUE NOT NULL,
  "名字" VARCHAR(20) NOT NULL,
  "名前" VARCHAR(20) NOT NULL,
  "氏名カナ" VARCHAR(50) NOT NULL,
  "メールアドレス" VARCHAR(255),
  "パスワード" VARCHAR(255) NOT NULL,
  "生年月日" TIMESTAMP(3) NOT NULL,
  "入社年月日" TIMESTAMP(3) NOT NULL,
  "退社年月日" TIMESTAMP(3),
  "職位コード" CHAR(3) NOT NULL,
  "最終ログイン日時" TIMESTAMP(3),
  "備考" VARCHAR(255),
  FOREIGN KEY ("職位コード") REFERENCES "kbn職位区分"("職位コード")
);
COMMENT ON TABLE mst従業員マスタ IS '従業員マスタ';
COMMENT ON COLUMN mst従業員マスタ.従業員コード IS '従業員コード';
COMMENT ON COLUMN mst従業員マスタ.名字 IS '名字';
COMMENT ON COLUMN mst従業員マスタ.名前 IS '名前';
COMMENT ON COLUMN mst従業員マスタ.氏名カナ IS '氏名カナ';
COMMENT ON COLUMN mst従業員マスタ.メールアドレス IS 'メールアドレス';
COMMENT ON COLUMN mst従業員マスタ.パスワード IS 'パスワード';
COMMENT ON COLUMN mst従業員マスタ.生年月日 IS '生年月日';
COMMENT ON COLUMN mst従業員マスタ.入社年月日 IS '入社年月日';
COMMENT ON COLUMN mst従業員マスタ.退社年月日 IS '退社年月日';
COMMENT ON COLUMN mst従業員マスタ.職位コード IS '職位コード';
COMMENT ON COLUMN mst従業員マスタ.最終ログイン日時 IS '最終ログイン日時';
COMMENT ON COLUMN mst従業員マスタ.備考 IS '備考';

CREATE TABLE "mst会員マスタ" (
  "会員コード" CHAR(10) PRIMARY KEY,
  "会員番号" VARCHAR(12) UNIQUE NOT NULL,
  "名字" VARCHAR(20) NOT NULL,
  "名前" VARCHAR(20) NOT NULL,
  "氏名カナ" VARCHAR(50) NOT NULL,
  "会社名" VARCHAR(50),
  "会社名カナ" VARCHAR(50),
  "電話番号" VARCHAR(20),
  "メールアドレス" VARCHAR(255),
  "入会年月日" TIMESTAMP(3) NOT NULL,
  "退会年月日" TIMESTAMP(3),
  "備考" VARCHAR(255)
);
COMMENT ON TABLE mst会員マスタ IS '会員マスタ';
COMMENT ON COLUMN mst会員マスタ.会員コード IS '会員コード';
COMMENT ON COLUMN mst会員マスタ.名字 IS '名字';
COMMENT ON COLUMN mst会員マスタ.名前 IS '名前';
COMMENT ON COLUMN mst会員マスタ.氏名カナ IS '氏名カナ';
COMMENT ON COLUMN mst会員マスタ.会社名 IS '会社名';
COMMENT ON COLUMN mst会員マスタ.会社名カナ IS '会社名カナ';
COMMENT ON COLUMN mst会員マスタ.電話番号 IS '電話番号';
COMMENT ON COLUMN mst会員マスタ.メールアドレス IS 'メールアドレス';
COMMENT ON COLUMN mst会員マスタ.入会年月日 IS '入会年月日';
COMMENT ON COLUMN mst会員マスタ.退会年月日 IS '退会年月日';
COMMENT ON COLUMN mst会員マスタ.備考 IS '備考';

CREATE TABLE "mst客室タイプマスタ" (
  "客室タイプコード" CHAR(4) PRIMARY KEY,
  "客室タイプ名称" VARCHAR(20) NOT NULL,
  "料金" INT NOT NULL,
  "宿泊人数" INT NOT NULL,
  "備考" VARCHAR(255)
);
COMMENT ON TABLE mst客室タイプマスタ IS '客室タイプマスタ';
COMMENT ON COLUMN mst客室タイプマスタ.客室タイプコード IS '客室タイプコード';
COMMENT ON COLUMN mst客室タイプマスタ.客室タイプ名称 IS '客室タイプ名称';
COMMENT ON COLUMN mst客室タイプマスタ.料金 IS '料金';
COMMENT ON COLUMN mst客室タイプマスタ.宿泊人数 IS '宿泊人数';
COMMENT ON COLUMN mst客室タイプマスタ.備考 IS '備考';

CREATE TABLE "mst客室マスタ" (
  "客室コード" CHAR(6) PRIMARY KEY,
  "客室番号" VARCHAR(3) UNIQUE NOT NULL,
  "客室タイプコード" CHAR(4) NOT NULL,
  "喫煙" BOOLEAN NOT NULL,
  "備考" VARCHAR(255),
  FOREIGN KEY ("客室タイプコード") REFERENCES "mst客室タイプマスタ"("客室タイプコード")
);
COMMENT ON TABLE mst客室マスタ IS '客室マスタ';
COMMENT ON COLUMN mst客室マスタ.客室コード IS '客室コード';
COMMENT ON COLUMN mst客室マスタ.客室タイプコード IS '客室タイプコード';
COMMENT ON COLUMN mst客室マスタ.喫煙 IS '喫煙';
COMMENT ON COLUMN mst客室マスタ.備考 IS '備考';

-- 台帳テーブル

CREATE TABLE "dch従業員職位履歴台帳" (
  "id" BIGINT NOT NULL PRIMARY KEY,
  "従業員コード" CHAR(10) NOT NULL,
  "職位コード" CHAR(3) NOT NULL,
  "適用開始日" TIMESTAMP(3) NOT NULL,
  "適用終了日" TIMESTAMP(3) NOT NULL,
  FOREIGN KEY ("従業員コード") REFERENCES "mst従業員マスタ"("従業員コード"),
  FOREIGN KEY ("職位コード") REFERENCES "kbn職位区分"("職位コード")
);
COMMENT ON TABLE dch従業員職位履歴台帳 IS '従業員職位履歴台帳';
COMMENT ON COLUMN dch従業員職位履歴台帳.id IS '従業員職位履歴台帳ID';
COMMENT ON COLUMN dch従業員職位履歴台帳.従業員コード IS '従業員コード';
COMMENT ON COLUMN dch従業員職位履歴台帳.職位コード IS '職位コード';
COMMENT ON COLUMN dch従業員職位履歴台帳.適用開始日 IS '適用開始日';
COMMENT ON COLUMN dch従業員職位履歴台帳.適用終了日 IS '適用終了日';

CREATE TABLE "dch月締確定台帳" (
  "対象年月" CHAR(6) PRIMARY KEY
);
COMMENT ON TABLE dch月締確定台帳 IS '月締確定台帳';
COMMENT ON COLUMN dch月締確定台帳.対象年月 IS '対象年月';

CREATE TABLE "dch客室利用台帳" (
  "id" BIGINT PRIMARY KEY,
  "客室利用コード" CHAR(3) NOT NULL,
  "客室コード" CHAR(6) NOT NULL,
  "開始予定日時" TIMESTAMP(3) NOT NULL,
  "終了予定日時" TIMESTAMP(3) NOT NULL,
  "開始実績日時" TIMESTAMP(3),
  "終了実績日時" TIMESTAMP(3),
  "備考" VARCHAR(255),
  FOREIGN KEY ("客室利用コード") REFERENCES "kbn客室利用区分"("客室利用コード"),
  FOREIGN KEY ("客室コード") REFERENCES "mst客室マスタ"("客室コード")
);
COMMENT ON TABLE dch客室利用台帳 IS '客室利用台帳 ';
COMMENT ON COLUMN dch客室利用台帳.id IS '客室利用台帳ID';
COMMENT ON COLUMN dch客室利用台帳.客室利用コード IS '客室利用コード';
COMMENT ON COLUMN dch客室利用台帳.客室コード IS '客室コード';
COMMENT ON COLUMN dch客室利用台帳.開始予定日時 IS '開始予定日時';
COMMENT ON COLUMN dch客室利用台帳.終了予定日時 IS '終了予定日時';
COMMENT ON COLUMN dch客室利用台帳.開始実績日時 IS '開始実績日時';
COMMENT ON COLUMN dch客室利用台帳.終了実績日時 IS '終了実績日時';
COMMENT ON COLUMN dch客室利用台帳.備考 IS '備考';

CREATE TABLE "dch宿泊利用台帳" (
  "客室利用台帳id" BIGINT PRIMARY KEY,
  "会員コード" CHAR(10) NOT NULL,
  "宿泊料金" INT NOT NULL,
  FOREIGN KEY ("客室利用台帳id") REFERENCES "dch客室利用台帳"("id"),
  FOREIGN KEY ("会員コード") REFERENCES "mst会員マスタ"("会員コード")
);
COMMENT ON TABLE dch宿泊利用台帳 IS '客室利用台帳 ';
COMMENT ON COLUMN dch宿泊利用台帳.客室利用台帳id IS '客室利用台帳ID';
COMMENT ON COLUMN dch宿泊利用台帳.会員コード IS '会員コード';
COMMENT ON COLUMN dch宿泊利用台帳.宿泊料金 IS '宿泊料金';

-- シーケンス

CREATE SEQUENCE "dch001_id_seq";
ALTER TABLE "dch従業員職位履歴台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch001_id_seq');

CREATE SEQUENCE "dch002_id_seq";
ALTER TABLE "dch客室利用台帳" ALTER COLUMN "id" SET DEFAULT nextval('dch002_id_seq');
