
-- Rank:職位区分
CREATE TABLE "rank" (
    "code" CHAR(3) NOT NULL PRIMARY KEY,
    "english_name" VARCHAR(20) NOT NULL,
    "japanese_name" VARCHAR(20) NOT NULL
);

-- RoomType:客室タイプ区分
CREATE TABLE "room_type" (
    "code" CHAR(3) NOT NULL PRIMARY KEY,
    "name" VARCHAR(20) NOT NULL,
    "price" INTEGER DEFAULT 0,
    "capacity" INTEGER DEFAULT 1,
    "description" VARCHAR(255) NOT NULL
);

-- Employee:従業員マスタ
CREATE TABLE "employee" (
    "id" BIGSERIAL NOT NULL PRIMARY KEY,
    "employee_no" VARCHAR(10) UNIQUE NOT NULL,
    "last_name" VARCHAR(20) NOT NULL,
    "first_name" VARCHAR(20) NOT NULL,
    "ruby_name"  VARCHAR(50) NOT NULL,
    "email" VARCHAR(255),
    "password" VARCHAR(255) NOT NULL,
    "rank_code" VARCHAR(3) NOT NULL,
    "entry_date" TIMESTAMP(3) NOT NULL,
    "leave_date" TIMESTAMP(3),
    FOREIGN KEY ("rank_code") REFERENCES "rank"("code")
);

-- Customer:顧客マスタ
CREATE TABLE "customer" (
    "id" BIGSERIAL NOT NULL PRIMARY KEY,
    "campany_name" VARCHAR(100),
    "last_name" VARCHAR(20) NOT NULL,
    "first_name" VARCHAR(20) NOT NULL
);

-- Room:客室マスタ
CREATE TABLE "room" (
    "id" BIGSERIAL NOT NULL PRIMARY KEY,
    "room_no" VARCHAR(10) UNIQUE NOT NULL,
    "room_type_code" VARCHAR(3) NOT NULL,
    "can_smoke" BOOLEAN
);
