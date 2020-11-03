-- KbnRank
CREATE TABLE "kbn_rank" (
    "code" VARCHAR(3) NOT NULL PRIMARY KEY,
    "english_name" VARCHAR(20) NOT NULL,
    "japanese_name" VARCHAR(20) NOT NULL
);

-- KbnRoomType
CREATE TABLE "kbn_room_type" (
    "code" VARCHAR(3) NOT NULL PRIMARY KEY,
    "name" VARCHAR(20) NOT NULL,
    "price" INTEGER DEFAULT 0,
    "capacity" INTEGER DEFAULT 1,
    "description" VARCHAR(255) NOT NULL
);

-- MstEmployee
CREATE TABLE "mst_employee" (
    "id" SERIAL NOT NULL PRIMARY KEY,
    "employee_no" VARCHAR(10) UNIQUE NOT NULL,
    "name" VARCHAR(50) NOT NULL,
    "password" VARCHAR(255) NOT NULL,
    "rank_code" VARCHAR(3) NOT NULL,
    "entry_date" TIMESTAMP(3) NOT NULL,
    "leave_date" TIMESTAMP(3),
    FOREIGN KEY ("rank_code") REFERENCES "kbn_rank"("code")
);

-- MstRoom
CREATE TABLE "mst_room" (
    "id" SERIAL NOT NULL PRIMARY KEY,
    "room_no" VARCHAR(10) UNIQUE NOT NULL,
    "room_type_code" VARCHAR(3) NOT NULL,
    "can_smoke" BOOLEAN
);

-- MstCustomer
CREATE TABLE "mst_customer" (
    "id" SERIAL NOT NULL PRIMARY KEY,
    "name" VARCHAR(50) NOT NULL
);