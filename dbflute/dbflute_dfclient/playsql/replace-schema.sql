-- Rank
CREATE TABLE "rank" (
    "code" CHAR(3) NOT NULL PRIMARY KEY,
    "english_name" VARCHAR(20) NOT NULL,
    "japanese_name" VARCHAR(20) NOT NULL
);

-- RoomType
CREATE TABLE "room_type" (
    "code" CHAR(3) NOT NULL PRIMARY KEY,
    "name" VARCHAR(20) NOT NULL,
    "price" INTEGER DEFAULT 0,
    "capacity" INTEGER DEFAULT 1,
    "description" VARCHAR(255) NOT NULL
);

-- Employee
CREATE TABLE "employee" (
    "id" BIGSERIAL NOT NULL PRIMARY KEY,
    "employee_no" VARCHAR(10) UNIQUE NOT NULL,
    "password" VARCHAR(255) NOT NULL,
    "rank_code" VARCHAR(3) NOT NULL,
    "last_name" VARCHAR(20) NOT NULL,
    "first_name" VARCHAR(20) NOT NULL,
    "entry_date" TIMESTAMP(3) NOT NULL,
    "leave_date" TIMESTAMP(3),
    FOREIGN KEY ("rank_code") REFERENCES "rank"("code")
);

-- Customer
CREATE TABLE "customer" (
    "id" BIGSERIAL NOT NULL PRIMARY KEY,
    "last_name" VARCHAR(20) NOT NULL,
    "first_name" VARCHAR(20) NOT NULL
);

-- Room
CREATE TABLE "room" (
    "id" BIGSERIAL NOT NULL PRIMARY KEY,
    "room_no" VARCHAR(10) UNIQUE NOT NULL,
    "room_type_code" VARCHAR(3) NOT NULL,
    "can_smoke" BOOLEAN
);
